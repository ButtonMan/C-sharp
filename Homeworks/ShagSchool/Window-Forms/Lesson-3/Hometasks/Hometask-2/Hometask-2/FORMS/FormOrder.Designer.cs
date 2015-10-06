namespace Hometask_2.Forms
{
    partial class FormOrder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.labelGood = new System.Windows.Forms.Label();
            this.listBoxOrderInfo = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelOrderInfo = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 66);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 0;
            this.textBoxPrice.Text = "0.00";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(9, 50);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(74, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Цена товара:";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(12, 26);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducts.Sorted = true;
            this.comboBoxProducts.TabIndex = 4;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProductsSelectesIndexChanged);
            // 
            // labelGood
            // 
            this.labelGood.AutoSize = true;
            this.labelGood.Location = new System.Drawing.Point(9, 10);
            this.labelGood.Name = "labelGood";
            this.labelGood.Size = new System.Drawing.Size(92, 13);
            this.labelGood.TabIndex = 5;
            this.labelGood.Text = "Выберите товар:";
            // 
            // listBoxOrderInfo
            // 
            this.listBoxOrderInfo.ColumnWidth = 150;
            this.listBoxOrderInfo.FormattingEnabled = true;
            this.listBoxOrderInfo.Location = new System.Drawing.Point(139, 26);
            this.listBoxOrderInfo.MultiColumn = true;
            this.listBoxOrderInfo.Name = "listBoxOrderInfo";
            this.listBoxOrderInfo.Size = new System.Drawing.Size(284, 238);
            this.listBoxOrderInfo.Sorted = true;
            this.listBoxOrderInfo.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonAdd.Location = new System.Drawing.Point(12, 141);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 37);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить в заказ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonEdit.Location = new System.Drawing.Point(12, 184);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 37);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEditClick);
            // 
            // labelOrderInfo
            // 
            this.labelOrderInfo.AutoSize = true;
            this.labelOrderInfo.Location = new System.Drawing.Point(136, 10);
            this.labelOrderInfo.Name = "labelOrderInfo";
            this.labelOrderInfo.Size = new System.Drawing.Size(99, 13);
            this.labelOrderInfo.TabIndex = 9;
            this.labelOrderInfo.Text = "Данные о заказе:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(9, 89);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(77, 13);
            this.labelTotalPrice.TabIndex = 10;
            this.labelTotalPrice.Text = "Сумма заказ:";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(12, 105);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalPrice.TabIndex = 11;
            this.textBoxTotalPrice.Text = "0.00";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonCreate.Location = new System.Drawing.Point(12, 227);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(121, 37);
            this.buttonCreate.TabIndex = 12;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(435, 276);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelOrderInfo);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxOrderInfo);
            this.Controls.Add(this.labelGood);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label labelGood;
        private System.Windows.Forms.ListBox listBoxOrderInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelOrderInfo;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Button buttonCreate;
    }
}

