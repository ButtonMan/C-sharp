using Hometask_2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask_2.Forms
{
    public partial class FormMain : Form
    {
        //ПОЛЯ КЛАССА
        //+-------------------------------------------------------------------+
        PersonData personData = null;               //данные о пользователе
        FormResult formResult = null;               //форма выводящая результат
                                                    //опроса



        //КОНСТРУКТОРЫ КЛАССА
        //+-------------------------------------------------------------------+
        public FormMain()
        {
            this.InitializeComponent();
            this.SetDefaultControlsValue();
        }
        public FormMain(ref PersonData personData) : this()
        {

            if (personData == null)
            {
                throw new ArgumentNullException("Идентификатор \"personData\"" +
                    "переданный в конструктор объекта класса FormMain" +
                    "содержит нулевую ссылку");
            }
            else
            {
                this.personData = personData;
            }
        }



        //ОБРАБОТЧИКИ СОБЫТИЙ
        //+-------------------------------------------------------------------+
        private void ButtonConfirmClick(Object sender, EventArgs e)
        {
            this.FormResultInitialaiz();
            Control[] labelPersonDateResult =
                this.formResult.Controls.Find("labelPersonDataResult", true);
            labelPersonDateResult[0].Text = (GetPersonData()).GetFullInfo;
        }
        private void ButtonExitClick(Object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void ProgressBarSet(object sender, EventArgs e)
        {
            this.toolStripProgressBarProcess.Value = 0;
            if(!String.IsNullOrEmpty(this.textBoxLastName.Text))
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if(!String.IsNullOrEmpty(this.textBoxFirstName.Text))
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if(!String.IsNullOrEmpty(this.textBoxSecondName.Text))
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if(this.radioButtonFemale.Checked || this.radioButtonMale.Checked)
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if (this.dateTimePickerBirthDate.Checked)
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if (this.comboBoxBirthCountry.SelectedItem != null)
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if(this.comboBoxBirthTown.SelectedItem != null)
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if(this.checkedListBoxBusy.SelectedItem != null)
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if(this.numericUpDownMonthlyIncome.Value != 0)
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
            if(this.trackBarContentment.Value != 0)
            {
                this.toolStripProgressBarProcess.PerformStep();
            }
        }



        //МЕТОДЫ КЛАССА
        //+-------------------------------------------------------------------+
        /// <summary>
        /// Создает форму для отображения введенных пользователем данных
        /// </summary>
        private void FormResultInitialaiz()
        {
            this.formResult = new FormResult();
            this.formResult.Owner = this;
            this.formResult.ShowDialog(this);
        }
        /// <summary>
        /// Получет значение выбранного переключателя "пол"
        /// </summary>
        /// <returns>Перечисление, содержащее в себе названия полов</returns>
        private PersonSex GetSex()
        {
            if (radioButtonFemale.Checked)
            {
                return PersonSex.мужской;
            }
            else
            {
                if (radioButtonMale.Checked)
                {
                    return PersonSex.женский;
                }
                else
                {
                    return PersonSex.unknown;
                }
            }
        }
        /// <summary>
        /// Помещает значения переданные пользователем в форму, в объект класса 
        /// PersonData
        /// </summary>
        /// <returns>объект класса PersonData</returns>
        private PersonData GetPersonData()
        {
            this.personData.lastName = (!String.IsNullOrEmpty(this.textBoxLastName.Text))?
                this.textBoxLastName.Text : "-не задано-";
            this.personData.firstName = (!String.IsNullOrEmpty(this.textBoxFirstName.Text))?
                this.textBoxFirstName.Text : "-не задано-";
            this.personData.secondName = (!String.IsNullOrEmpty(this.textBoxSecondName.Text))? 
                this.textBoxSecondName.Text : "-не задано-";
            this.personData.Sex = this.GetSex();
            this.personData.BirthDate = this.dateTimePickerBirthDate.Value.ToShortDateString();
            this.personData.BirthCountry = this.comboBoxBirthCountry.SelectedItem.ToString();
            this.personData.BirthTown = this.comboBoxBirthTown.SelectedItem.ToString();
            this.personData.Busy = (this.checkedListBoxBusy.SelectedItem != null)?
                this.checkedListBoxBusy.SelectedItem.ToString() : "-не выбрано-";
            this.personData.MonthlyIncome = this.numericUpDownMonthlyIncome.Value.ToString();
            this.personData.Contentment = this.trackBarContentment.Value;
            return this.personData;
        }
        /// <summary>
        /// Присваивает контроллерам главной формы, значения по умолчанию
        /// </summary>
        private void SetDefaultControlsValue()
        {
            this.comboBoxBirthCountry.SelectedIndex = 
                this.comboBoxBirthCountry.Items.IndexOf("-не задано-");
            this.comboBoxBirthTown.SelectedIndex =
                this.comboBoxBirthCountry.Items.IndexOf("-не задано-");
        }
    }
}
