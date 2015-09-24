namespace Hometask_7
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
            this.labelMonthCalendarInfo = new System.Windows.Forms.Label();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.groupBoxTimeStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonSeconds = new System.Windows.Forms.RadioButton();
            this.radioButtonMinutes = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonMonths = new System.Windows.Forms.RadioButton();
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.panelTimeLeftInfo = new System.Windows.Forms.Panel();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelTimeLeftInfo = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonExite = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTimeStyle.SuspendLayout();
            this.panelTimeLeftInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMonthCalendarInfo
            // 
            this.labelMonthCalendarInfo.AutoSize = true;
            this.labelMonthCalendarInfo.Location = new System.Drawing.Point(9, 110);
            this.labelMonthCalendarInfo.Name = "labelMonthCalendarInfo";
            this.labelMonthCalendarInfo.Size = new System.Drawing.Size(85, 13);
            this.labelMonthCalendarInfo.TabIndex = 2;
            this.labelMonthCalendarInfo.Text = "Выберите дату:";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskDescription.Location = new System.Drawing.Point(6, 23);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(460, 62);
            this.labelTaskDescription.TabIndex = 3;
            this.labelTaskDescription.Text = "Расчет количества оставшегося времени до указанной даты:";
            // 
            // groupBoxTimeStyle
            // 
            this.groupBoxTimeStyle.Controls.Add(this.radioButtonSeconds);
            this.groupBoxTimeStyle.Controls.Add(this.radioButtonMinutes);
            this.groupBoxTimeStyle.Controls.Add(this.radioButtonDays);
            this.groupBoxTimeStyle.Controls.Add(this.radioButtonMonths);
            this.groupBoxTimeStyle.Controls.Add(this.radioButtonYears);
            this.groupBoxTimeStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxTimeStyle.Location = new System.Drawing.Point(12, 152);
            this.groupBoxTimeStyle.Name = "groupBoxTimeStyle";
            this.groupBoxTimeStyle.Size = new System.Drawing.Size(286, 60);
            this.groupBoxTimeStyle.TabIndex = 4;
            this.groupBoxTimeStyle.TabStop = false;
            this.groupBoxTimeStyle.Text = "Удиницы измерения";
            // 
            // radioButtonSeconds
            // 
            this.radioButtonSeconds.AutoSize = true;
            this.radioButtonSeconds.Location = new System.Drawing.Point(195, 13);
            this.radioButtonSeconds.Name = "radioButtonSeconds";
            this.radioButtonSeconds.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSeconds.TabIndex = 4;
            this.radioButtonSeconds.TabStop = true;
            this.radioButtonSeconds.Text = "секунды";
            this.radioButtonSeconds.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinutes
            // 
            this.radioButtonMinutes.AutoSize = true;
            this.radioButtonMinutes.Location = new System.Drawing.Point(102, 38);
            this.radioButtonMinutes.Name = "radioButtonMinutes";
            this.radioButtonMinutes.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMinutes.TabIndex = 3;
            this.radioButtonMinutes.TabStop = true;
            this.radioButtonMinutes.Text = "минуты";
            this.radioButtonMinutes.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Location = new System.Drawing.Point(102, 13);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(43, 17);
            this.radioButtonDays.TabIndex = 2;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "дни";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonths
            // 
            this.radioButtonMonths.AutoSize = true;
            this.radioButtonMonths.Location = new System.Drawing.Point(7, 38);
            this.radioButtonMonths.Name = "radioButtonMonths";
            this.radioButtonMonths.Size = new System.Drawing.Size(65, 17);
            this.radioButtonMonths.TabIndex = 1;
            this.radioButtonMonths.TabStop = true;
            this.radioButtonMonths.Text = "месяцы";
            this.radioButtonMonths.UseVisualStyleBackColor = true;
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.AutoSize = true;
            this.radioButtonYears.Location = new System.Drawing.Point(7, 14);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(50, 17);
            this.radioButtonYears.TabIndex = 0;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "годы";
            this.radioButtonYears.UseMnemonic = false;
            this.radioButtonYears.UseVisualStyleBackColor = true;
            // 
            // panelTimeLeftInfo
            // 
            this.panelTimeLeftInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTimeLeftInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimeLeftInfo.Controls.Add(this.labelTimeLeft);
            this.panelTimeLeftInfo.Controls.Add(this.labelTimeLeftInfo);
            this.panelTimeLeftInfo.Location = new System.Drawing.Point(12, 218);
            this.panelTimeLeftInfo.Name = "panelTimeLeftInfo";
            this.panelTimeLeftInfo.Size = new System.Drawing.Size(460, 84);
            this.panelTimeLeftInfo.TabIndex = 5;
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeLeft.Location = new System.Drawing.Point(3, 17);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(321, 55);
            this.labelTimeLeft.TabIndex = 1;
            this.labelTimeLeft.Text = "00000000000";
            // 
            // labelTimeLeftInfo
            // 
            this.labelTimeLeftInfo.AutoSize = true;
            this.labelTimeLeftInfo.Location = new System.Drawing.Point(10, 4);
            this.labelTimeLeftInfo.Name = "labelTimeLeftInfo";
            this.labelTimeLeftInfo.Size = new System.Drawing.Size(69, 13);
            this.labelTimeLeftInfo.TabIndex = 0;
            this.labelTimeLeftInfo.Text = "Количество:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConfirm.Location = new System.Drawing.Point(323, 125);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(149, 43);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.HandlerButtonConfirmClick);
            // 
            // buttonExite
            // 
            this.buttonExite.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExite.Location = new System.Drawing.Point(323, 170);
            this.buttonExite.Name = "buttonExite";
            this.buttonExite.Size = new System.Drawing.Size(149, 43);
            this.buttonExite.TabIndex = 7;
            this.buttonExite.Text = "Выйти";
            this.buttonExite.UseVisualStyleBackColor = true;
            this.buttonExite.Click += new System.EventHandler(this.HandlerButtonCanselClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 126);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(286, 20);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.Value = new System.DateTime(2015, 9, 22, 0, 0, 0, 0);
            this.dateTimePicker.CloseUp += new System.EventHandler(this.DateTimePickeCloseUp);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePickeValueChenged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 338);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonExite);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.panelTimeLeftInfo);
            this.Controls.Add(this.groupBoxTimeStyle);
            this.Controls.Add(this.labelTaskDescription);
            this.Controls.Add(this.labelMonthCalendarInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнее задание №7";
            this.groupBoxTimeStyle.ResumeLayout(false);
            this.groupBoxTimeStyle.PerformLayout();
            this.panelTimeLeftInfo.ResumeLayout(false);
            this.panelTimeLeftInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMonthCalendarInfo;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.GroupBox groupBoxTimeStyle;
        private System.Windows.Forms.RadioButton radioButtonMinutes;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.RadioButton radioButtonMonths;
        private System.Windows.Forms.RadioButton radioButtonYears;
        private System.Windows.Forms.Panel panelTimeLeftInfo;
        private System.Windows.Forms.RadioButton radioButtonSeconds;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label labelTimeLeftInfo;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonExite;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

