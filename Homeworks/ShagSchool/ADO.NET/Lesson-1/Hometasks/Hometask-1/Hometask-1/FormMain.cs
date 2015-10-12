using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_1
{
    public partial class FormMain: Form
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+

        SqlConnection dbConnection = null;
        SqlConnectionStringBuilder sqlStringBuilder = null;
        SqlCommand command = null;
        SqlDataReader reader = null;



        //КОНСТРУКТОР КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создание окна и его элементов
        /// </summary>
        public FormMain()
        {
            try
            {
                this.DbInitialization();
                this.InitializeComponent();
                this.EventSubscriptionInitialization();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+

        /// <summary>
        /// Создание подключения к базе данных "SALES"
        /// </summary>
        private void DbInitialization()
        {
            this.sqlStringBuilder = new SqlConnectionStringBuilder();
            this.sqlStringBuilder.DataSource = "TAMARRA";
            this.sqlStringBuilder.IntegratedSecurity = true;
            this.sqlStringBuilder.InitialCatalog = "SALES";

            this.dbConnection = new SqlConnection();
            this.dbConnection.ConnectionString = this.sqlStringBuilder.ConnectionString;
            this.dbConnection.Open();        
        }

        /// <summary>
        /// Закрытие подключеия к базе данных "SALES"
        /// </summary>
        private void DbDrop(Object sender, FormClosedEventArgs e)
        {
            if (this.dbConnection != null)
            {
                this.dbConnection.Close();
                this.dbConnection = null;
            }
        }

        /// <summary>
        /// Подкиска обработчиков событий на события
        /// </summary>
        private void EventSubscriptionInitialization()
        {
            this.comboBoxTable.DropDown += new EventHandler(this.SetComboBoxItems);
            this.comboBoxTable.SelectedIndexChanged += new EventHandler(this.SetTextBoxText);
            this.FormClosed += new FormClosedEventHandler(DbDrop);
        }

        /// <summary>
        /// Заполнение строк выпадающего меню элемента "ComboBox"
        /// </summary>
        private void SetComboBoxItems(Object sender, EventArgs e)
        {
            try
            {
                if(this.comboBoxTable.Items != null)
                {
                    this.comboBoxTable.Items.Clear();
                }
                this.command = new SqlCommand("SELECT [TABLE_NAME] " +
                    "FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' " +
                    "AND TABLE_CATALOG = 'SALES'", dbConnection);
                reader = this.command.ExecuteReader();

                List<Object> items = new List<Object>();
                while (this.reader.Read())
                {
                    items.Add(reader["TABLE_NAME"]);
                }
                this.comboBoxTable.Items.AddRange(items.ToArray());
            }
            finally
            {
                if(this.reader != null)
                {
                    this.reader.Close();
                    this.reader = null;
                }
            }    
        }

        /// <summary>
        /// Заполнение текстом элемента "TextBox"
        /// </summary>
        private void SetTextBoxText(Object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxTableData.Text != null)
                {
                    this.textBoxTableData.Text = null;
                }

                String sqlQuery = null;
                if ((string)this.comboBoxTable.SelectedItem == "Buyers" ||
                   (string)this.comboBoxTable.SelectedItem == "Sellers")
                {
                    sqlQuery = String.Format("SELECT * FROM [{0}]",
                        (string)this.comboBoxTable.SelectedItem);
                }
                else
                {
                    sqlQuery = String.Format(
                        "SELECT[Sellers].[LastName] AS[Seller Last Name], " +
                        "[Sellers].[FirstName] AS[Seller First Name], " +
                        "[Buyers].[LastName] AS[Buyer Last Name], " +
                        "[Buyers].[FirstName] AS[Buyer First Name], " +
                        "[Sales].[Total] AS[Total Sales] " +
                        "FROM[Sellers] INNER JOIN([Buyers] " +
                        "INNER JOIN[Sales] ON[Buyers].[BuyerId] = " + 
                        "[Sales].[BuyerId]) ON [Sellers].SellerId = " +
                        "[Sales].[SellerId] ORDER BY[Total Sales] DESC ");
                }

                this.command = new SqlCommand(sqlQuery, this.dbConnection);
                reader = this.command.ExecuteReader();

                StringBuilder tableColumnNames = new StringBuilder();
                tableColumnNames = GetTableColumsNames();
                StringBuilder tableRows = new StringBuilder();
                tableRows = GetTableRows();

                this.textBoxTableData.AppendText(tableColumnNames.ToString() +
                    tableRows.ToString());
                this.textBoxTableData.ScrollBars = ScrollBars.Both;
            }
            finally
            {
                if (this.reader != null)
                {
                    this.reader.Close();
                    this.reader = null;
                }
            }
        }

        /// <summary>
        /// Возвращает имена столбцов таблицы
        /// </summary>
        /// <returns>имена столбцов таблицы</returns>
        private StringBuilder GetTableColumsNames()
        {
            StringBuilder tableColumnNames = new StringBuilder();

            //Вставка в текст заголовков столбцов
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (i == 0)
                {
                    tableColumnNames.AppendFormat("{0, -20}", 
                        reader.GetName(i));
                }
                else
                {
                    tableColumnNames.AppendFormat("{0, -20}", 
                        reader.GetName(i));
                }
            }
            tableColumnNames.AppendLine(Environment.NewLine);

            return tableColumnNames;
        }

        /// <summary>
        /// Возвращает данные содержащиеся в таблице
        /// </summary>
        /// <returns>данные таблицы</returns>
        private StringBuilder GetTableRows()
        {
            StringBuilder tableRows = new StringBuilder();

            //Вставка в текст данных таблицы
            while (this.reader.Read() != false)
            {
                for (int i = 0; i < this.reader.FieldCount; i++)
                {
                    if (i == 0)
                    {
                        tableRows.AppendFormat("{0,-20}", reader[i]);
                    }
                    else
                    {
                        tableRows.AppendFormat("{0,-20}", reader[i]);
                    }
                }
                tableRows.AppendLine();
            }

            return tableRows;
        }
    }
}
