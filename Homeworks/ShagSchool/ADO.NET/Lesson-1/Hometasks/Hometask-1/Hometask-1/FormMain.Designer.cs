namespace Hometask_1
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
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.labelTable = new System.Windows.Forms.Label();
            this.textBoxTableData = new System.Windows.Forms.TextBox();
            this.labelTableData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(12, 25);
            this.comboBoxTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(260, 21);
            this.comboBoxTable.TabIndex = 0;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(9, 9);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(89, 13);
            this.labelTable.TabIndex = 1;
            this.labelTable.Text = "Выбор таблицы:";
            // 
            // textBoxTableData
            // 
            this.textBoxTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTableData.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTableData.Location = new System.Drawing.Point(12, 65);
            this.textBoxTableData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTableData.Multiline = true;
            this.textBoxTableData.Name = "textBoxTableData";
            this.textBoxTableData.ReadOnly = true;
            this.textBoxTableData.Size = new System.Drawing.Size(748, 183);
            this.textBoxTableData.TabIndex = 2;
            // 
            // labelTableData
            // 
            this.labelTableData.AutoSize = true;
            this.labelTableData.Location = new System.Drawing.Point(12, 48);
            this.labelTableData.Name = "labelTableData";
            this.labelTableData.Size = new System.Drawing.Size(97, 13);
            this.labelTableData.TabIndex = 3;
            this.labelTableData.Text = "Данные таблицы:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(772, 261);
            this.Controls.Add(this.labelTableData);
            this.Controls.Add(this.textBoxTableData);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.comboBoxTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнее задание №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.TextBox textBoxTableData;
        private System.Windows.Forms.Label labelTableData;
    }
}

