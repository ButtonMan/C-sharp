namespace Hometask_2.Forms
{
    partial class FormMain
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelBirthCountry = new System.Windows.Forms.Label();
            this.comboBoxBirthCountry = new System.Windows.Forms.ComboBox();
            this.groupBoxBirthPlace = new System.Windows.Forms.GroupBox();
            this.labelBirthTown = new System.Windows.Forms.Label();
            this.comboBoxBirthTown = new System.Windows.Forms.ComboBox();
            this.groupBoxBusy = new System.Windows.Forms.GroupBox();
            this.labelBusy = new System.Windows.Forms.Label();
            this.checkedListBoxBusy = new System.Windows.Forms.CheckedListBox();
            this.groupBoxProsperity = new System.Windows.Forms.GroupBox();
            this.labelMonthlyIncome = new System.Windows.Forms.Label();
            this.numericUpDownMonthlyIncome = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelProсess = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarContentment = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBoxBirthPlace.SuspendLayout();
            this.groupBoxBusy.SuspendLayout();
            this.groupBoxProsperity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonthlyIncome)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContentment)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 28);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(101, 25);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(239, 20);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.ProgressBarSet);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBox1.Controls.Add(this.labelBirthDate);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.labelSex);
            this.groupBox1.Controls.Add(this.labelSecondName);
            this.groupBox1.Controls.Add(this.textBoxSecondName);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональные данные";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(101, 125);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerBirthDate.TabIndex = 10;
            this.dateTimePickerBirthDate.ValueChanged += new System.EventHandler(this.ProgressBarSet);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(6, 129);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(86, 13);
            this.labelBirthDate.TabIndex = 9;
            this.labelBirthDate.Text = "Дата рождения";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(192, 102);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(72, 17);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Женский";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.ProgressBarSet);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(101, 102);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemale.TabIndex = 7;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Мужской";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.ProgressBarSet);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(8, 104);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(27, 13);
            this.labelSex.TabIndex = 6;
            this.labelSex.Text = "Пол";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(6, 80);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(54, 13);
            this.labelSecondName.TabIndex = 4;
            this.labelSecondName.Text = "Отчество";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(101, 77);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(239, 20);
            this.textBoxSecondName.TabIndex = 5;
            this.textBoxSecondName.TextChanged += new System.EventHandler(this.ProgressBarSet);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 54);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(101, 51);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(239, 20);
            this.textBoxFirstName.TabIndex = 3;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.ProgressBarSet);
            // 
            // labelBirthCountry
            // 
            this.labelBirthCountry.AutoSize = true;
            this.labelBirthCountry.Location = new System.Drawing.Point(7, 27);
            this.labelBirthCountry.Name = "labelBirthCountry";
            this.labelBirthCountry.Size = new System.Drawing.Size(43, 13);
            this.labelBirthCountry.TabIndex = 12;
            this.labelBirthCountry.Text = "Страна";
            // 
            // comboBoxBirthCountry
            // 
            this.comboBoxBirthCountry.FormattingEnabled = true;
            this.comboBoxBirthCountry.Items.AddRange(new object[] {
            "-не задано-",
            "Англия",
            "Индия",
            "Китай",
            "Мексика",
            "США",
            "Украина"});
            this.comboBoxBirthCountry.Location = new System.Drawing.Point(100, 24);
            this.comboBoxBirthCountry.Name = "comboBoxBirthCountry";
            this.comboBoxBirthCountry.Size = new System.Drawing.Size(163, 21);
            this.comboBoxBirthCountry.Sorted = true;
            this.comboBoxBirthCountry.TabIndex = 13;
            this.comboBoxBirthCountry.SelectionChangeCommitted += new System.EventHandler(this.ProgressBarSet);
            // 
            // groupBoxBirthPlace
            // 
            this.groupBoxBirthPlace.Controls.Add(this.labelBirthTown);
            this.groupBoxBirthPlace.Controls.Add(this.comboBoxBirthTown);
            this.groupBoxBirthPlace.Controls.Add(this.labelBirthCountry);
            this.groupBoxBirthPlace.Controls.Add(this.comboBoxBirthCountry);
            this.groupBoxBirthPlace.Location = new System.Drawing.Point(13, 180);
            this.groupBoxBirthPlace.Name = "groupBoxBirthPlace";
            this.groupBoxBirthPlace.Size = new System.Drawing.Size(345, 93);
            this.groupBoxBirthPlace.TabIndex = 14;
            this.groupBoxBirthPlace.TabStop = false;
            this.groupBoxBirthPlace.Text = "Место рождения";
            // 
            // labelBirthTown
            // 
            this.labelBirthTown.AutoSize = true;
            this.labelBirthTown.Location = new System.Drawing.Point(7, 54);
            this.labelBirthTown.Name = "labelBirthTown";
            this.labelBirthTown.Size = new System.Drawing.Size(37, 13);
            this.labelBirthTown.TabIndex = 14;
            this.labelBirthTown.Text = "Город";
            // 
            // comboBoxBirthTown
            // 
            this.comboBoxBirthTown.FormattingEnabled = true;
            this.comboBoxBirthTown.Items.AddRange(new object[] {
            "-не задано-",
            "Днепропетровск",
            "Донецк",
            "Киев",
            "Одесса",
            "Харьков"});
            this.comboBoxBirthTown.Location = new System.Drawing.Point(100, 51);
            this.comboBoxBirthTown.Name = "comboBoxBirthTown";
            this.comboBoxBirthTown.Size = new System.Drawing.Size(163, 21);
            this.comboBoxBirthTown.Sorted = true;
            this.comboBoxBirthTown.TabIndex = 15;
            this.comboBoxBirthTown.SelectionChangeCommitted += new System.EventHandler(this.ProgressBarSet);
            // 
            // groupBoxBusy
            // 
            this.groupBoxBusy.Controls.Add(this.labelBusy);
            this.groupBoxBusy.Controls.Add(this.checkedListBoxBusy);
            this.groupBoxBusy.Location = new System.Drawing.Point(12, 279);
            this.groupBoxBusy.Name = "groupBoxBusy";
            this.groupBoxBusy.Size = new System.Drawing.Size(346, 135);
            this.groupBoxBusy.TabIndex = 15;
            this.groupBoxBusy.TabStop = false;
            this.groupBoxBusy.Text = "Занятось";
            // 
            // labelBusy
            // 
            this.labelBusy.Location = new System.Drawing.Point(7, 24);
            this.labelBusy.Name = "labelBusy";
            this.labelBusy.Size = new System.Drawing.Size(85, 28);
            this.labelBusy.TabIndex = 1;
            this.labelBusy.Text = "Степень занятости";
            // 
            // checkedListBoxBusy
            // 
            this.checkedListBoxBusy.FormattingEnabled = true;
            this.checkedListBoxBusy.Items.AddRange(new object[] {
            "школьник",
            "студент",
            "пенсионер",
            "домохозяка",
            "рабочий",
            "офисный сотрудник",
            "начальник отдела",
            "директор"});
            this.checkedListBoxBusy.Location = new System.Drawing.Point(101, 24);
            this.checkedListBoxBusy.Name = "checkedListBoxBusy";
            this.checkedListBoxBusy.Size = new System.Drawing.Size(239, 94);
            this.checkedListBoxBusy.TabIndex = 0;
            // 
            // groupBoxProsperity
            // 
            this.groupBoxProsperity.Controls.Add(this.labelMonthlyIncome);
            this.groupBoxProsperity.Controls.Add(this.numericUpDownMonthlyIncome);
            this.groupBoxProsperity.Location = new System.Drawing.Point(13, 420);
            this.groupBoxProsperity.Name = "groupBoxProsperity";
            this.groupBoxProsperity.Size = new System.Drawing.Size(346, 56);
            this.groupBoxProsperity.TabIndex = 16;
            this.groupBoxProsperity.TabStop = false;
            this.groupBoxProsperity.Text = "Уровень достатка";
            // 
            // labelMonthlyIncome
            // 
            this.labelMonthlyIncome.AutoSize = true;
            this.labelMonthlyIncome.Location = new System.Drawing.Point(7, 22);
            this.labelMonthlyIncome.Name = "labelMonthlyIncome";
            this.labelMonthlyIncome.Size = new System.Drawing.Size(91, 13);
            this.labelMonthlyIncome.TabIndex = 1;
            this.labelMonthlyIncome.Text = "Месячный доход";
            // 
            // numericUpDownMonthlyIncome
            // 
            this.numericUpDownMonthlyIncome.Location = new System.Drawing.Point(101, 20);
            this.numericUpDownMonthlyIncome.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownMonthlyIncome.Name = "numericUpDownMonthlyIncome";
            this.numericUpDownMonthlyIncome.Size = new System.Drawing.Size(163, 20);
            this.numericUpDownMonthlyIncome.TabIndex = 0;
            this.numericUpDownMonthlyIncome.ValueChanged += new System.EventHandler(this.ProgressBarSet);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelProсess,
            this.toolStripProgressBarProcess});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(351, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStripFormMain";
            // 
            // toolStripStatusLabelProсess
            // 
            this.toolStripStatusLabelProсess.Name = "toolStripStatusLabelProсess";
            this.toolStripStatusLabelProсess.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabelProсess.Text = "Процесс заполнения анкеты:";
            // 
            // toolStripProgressBarProcess
            // 
            this.toolStripProgressBarProcess.Maximum = 10;
            this.toolStripProgressBarProcess.Name = "toolStripProgressBarProcess";
            this.toolStripProgressBarProcess.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBarProcess.Step = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(9, 576);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(172, 43);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirmClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(188, 576);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(172, 43);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBarContentment);
            this.groupBox2.Location = new System.Drawing.Point(13, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 69);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оценка удовлетворенности товаром";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "+50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "-50";
            // 
            // trackBarContentment
            // 
            this.trackBarContentment.LargeChange = 15;
            this.trackBarContentment.Location = new System.Drawing.Point(7, 19);
            this.trackBarContentment.Maximum = 50;
            this.trackBarContentment.Minimum = -50;
            this.trackBarContentment.Name = "trackBarContentment";
            this.trackBarContentment.Size = new System.Drawing.Size(332, 45);
            this.trackBarContentment.TabIndex = 0;
            this.trackBarContentment.ValueChanged += new System.EventHandler(this.ProgressBarSet);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(368, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxProsperity);
            this.Controls.Add(this.groupBoxBusy);
            this.Controls.Add(this.groupBoxBirthPlace);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнее задание №2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBirthPlace.ResumeLayout(false);
            this.groupBoxBirthPlace.PerformLayout();
            this.groupBoxBusy.ResumeLayout(false);
            this.groupBoxProsperity.ResumeLayout(false);
            this.groupBoxProsperity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonthlyIncome)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContentment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelBirthCountry;
        private System.Windows.Forms.ComboBox comboBoxBirthCountry;
        private System.Windows.Forms.GroupBox groupBoxBirthPlace;
        private System.Windows.Forms.Label labelBirthTown;
        private System.Windows.Forms.ComboBox comboBoxBirthTown;
        private System.Windows.Forms.GroupBox groupBoxBusy;
        private System.Windows.Forms.Label labelBusy;
        private System.Windows.Forms.CheckedListBox checkedListBoxBusy;
        private System.Windows.Forms.GroupBox groupBoxProsperity;
        private System.Windows.Forms.Label labelMonthlyIncome;
        private System.Windows.Forms.NumericUpDown numericUpDownMonthlyIncome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProсess;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarProcess;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarContentment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

