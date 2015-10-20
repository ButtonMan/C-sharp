namespace BasicWorks_ListView
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
            this.listView = new System.Windows.Forms.ListView();
            this.buttonSetFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(13, 13);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(259, 183);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSetFolder
            // 
            this.buttonSetFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetFolder.Location = new System.Drawing.Point(13, 203);
            this.buttonSetFolder.Name = "buttonSetFolder";
            this.buttonSetFolder.Size = new System.Drawing.Size(259, 46);
            this.buttonSetFolder.TabIndex = 1;
            this.buttonSetFolder.Text = "Выбрать папку";
            this.buttonSetFolder.UseVisualStyleBackColor = true;
            this.buttonSetFolder.Click += new System.EventHandler(this.buttonSetFolder_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSetFolder);
            this.Controls.Add(this.listView);
            this.Name = "FormMain";
            this.Text = "Просмотр содержимого";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button buttonSetFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

