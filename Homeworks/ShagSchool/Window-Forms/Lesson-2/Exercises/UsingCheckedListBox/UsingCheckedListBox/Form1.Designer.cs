namespace UsingCheckedListBox
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
            this.checkedListBoxUsers = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxUsersSelected = new System.Windows.Forms.CheckedListBox();
            this.textBoxNewItem = new System.Windows.Forms.TextBox();
            this.buttonAddToCheckedListBox = new System.Windows.Forms.Button();
            this.buttonAddSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxUsers
            // 
            this.checkedListBoxUsers.FormattingEnabled = true;
            this.checkedListBoxUsers.Items.AddRange(new object[] {
            "Сергей",
            "Юля",
            "Саша",
            "Ваня",
            "Дима",
            "Женя",
            "Настя"});
            this.checkedListBoxUsers.Location = new System.Drawing.Point(12, 45);
            this.checkedListBoxUsers.Name = "checkedListBoxUsers";
            this.checkedListBoxUsers.Size = new System.Drawing.Size(168, 124);
            this.checkedListBoxUsers.TabIndex = 0;
            // 
            // checkedListBoxUsersSelected
            // 
            this.checkedListBoxUsersSelected.FormattingEnabled = true;
            this.checkedListBoxUsersSelected.Location = new System.Drawing.Point(204, 45);
            this.checkedListBoxUsersSelected.Name = "checkedListBoxUsersSelected";
            this.checkedListBoxUsersSelected.Size = new System.Drawing.Size(168, 124);
            this.checkedListBoxUsersSelected.TabIndex = 1;
            // 
            // textBoxNewItem
            // 
            this.textBoxNewItem.Location = new System.Drawing.Point(12, 211);
            this.textBoxNewItem.Name = "textBoxNewItem";
            this.textBoxNewItem.Size = new System.Drawing.Size(168, 20);
            this.textBoxNewItem.TabIndex = 2;
            // 
            // buttonAddToCheckedListBox
            // 
            this.buttonAddToCheckedListBox.Location = new System.Drawing.Point(12, 266);
            this.buttonAddToCheckedListBox.Name = "buttonAddToCheckedListBox";
            this.buttonAddToCheckedListBox.Size = new System.Drawing.Size(168, 40);
            this.buttonAddToCheckedListBox.TabIndex = 3;
            this.buttonAddToCheckedListBox.Text = "Add to CheckedListBox";
            this.buttonAddToCheckedListBox.UseVisualStyleBackColor = true;
            this.buttonAddToCheckedListBox.Click += new System.EventHandler(this.ButtonAddToCheckedBoxClickOn);
            // 
            // buttonAddSelected
            // 
            this.buttonAddSelected.Location = new System.Drawing.Point(204, 266);
            this.buttonAddSelected.Name = "buttonAddSelected";
            this.buttonAddSelected.Size = new System.Drawing.Size(168, 40);
            this.buttonAddSelected.TabIndex = 4;
            this.buttonAddSelected.Text = "Add selected";
            this.buttonAddSelected.UseVisualStyleBackColor = true;
            this.buttonAddSelected.Click += new System.EventHandler(this.ButtonAddSelectedClickOn);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonAddSelected);
            this.Controls.Add(this.buttonAddToCheckedListBox);
            this.Controls.Add(this.textBoxNewItem);
            this.Controls.Add(this.checkedListBoxUsersSelected);
            this.Controls.Add(this.checkedListBoxUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Использование контроллера CheckedListBox";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxUsers;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsersSelected;
        private System.Windows.Forms.TextBox textBoxNewItem;
        private System.Windows.Forms.Button buttonAddToCheckedListBox;
        private System.Windows.Forms.Button buttonAddSelected;
    }
}

