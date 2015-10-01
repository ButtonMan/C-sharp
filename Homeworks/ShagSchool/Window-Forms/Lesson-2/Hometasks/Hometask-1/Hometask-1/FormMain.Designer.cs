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
            this.labelFileDirectoryOpen = new System.Windows.Forms.Label();
            this.textBoxFileDirectoryOpen = new System.Windows.Forms.TextBox();
            this.textBoxFileDirectorySave = new System.Windows.Forms.TextBox();
            this.labelFileDirectorySave = new System.Windows.Forms.Label();
            this.progressBarFileCoping = new System.Windows.Forms.ProgressBar();
            this.labelFileCoping = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labelFileDirectoryOpen
            // 
            this.labelFileDirectoryOpen.AutoSize = true;
            this.labelFileDirectoryOpen.Location = new System.Drawing.Point(10, 14);
            this.labelFileDirectoryOpen.Name = "labelFileDirectoryOpen";
            this.labelFileDirectoryOpen.Size = new System.Drawing.Size(77, 13);
            this.labelFileDirectoryOpen.TabIndex = 0;
            this.labelFileDirectoryOpen.Text = "Путь к файлу:";
            // 
            // textBoxFileDirectoryOpen
            // 
            this.textBoxFileDirectoryOpen.Location = new System.Drawing.Point(13, 30);
            this.textBoxFileDirectoryOpen.Name = "textBoxFileDirectoryOpen";
            this.textBoxFileDirectoryOpen.Size = new System.Drawing.Size(259, 20);
            this.textBoxFileDirectoryOpen.TabIndex = 1;
            this.textBoxFileDirectoryOpen.Click += new System.EventHandler(this.TextBoxFileDirectoryOpenClick);
            // 
            // textBoxFileDirectorySave
            // 
            this.textBoxFileDirectorySave.Location = new System.Drawing.Point(13, 75);
            this.textBoxFileDirectorySave.Name = "textBoxFileDirectorySave";
            this.textBoxFileDirectorySave.Size = new System.Drawing.Size(259, 20);
            this.textBoxFileDirectorySave.TabIndex = 3;
            this.textBoxFileDirectorySave.Click += new System.EventHandler(this.TextBoxFileDirectorySaveClick);
            // 
            // labelFileDirectorySave
            // 
            this.labelFileDirectorySave.AutoSize = true;
            this.labelFileDirectorySave.Location = new System.Drawing.Point(10, 59);
            this.labelFileDirectorySave.Name = "labelFileDirectorySave";
            this.labelFileDirectorySave.Size = new System.Drawing.Size(131, 13);
            this.labelFileDirectorySave.TabIndex = 2;
            this.labelFileDirectorySave.Text = "Путь сохранения файла:";
            // 
            // progressBarFileCoping
            // 
            this.progressBarFileCoping.Location = new System.Drawing.Point(13, 140);
            this.progressBarFileCoping.Name = "progressBarFileCoping";
            this.progressBarFileCoping.Size = new System.Drawing.Size(259, 32);
            this.progressBarFileCoping.TabIndex = 4;
            // 
            // labelFileCoping
            // 
            this.labelFileCoping.AutoSize = true;
            this.labelFileCoping.Location = new System.Drawing.Point(10, 124);
            this.labelFileCoping.Name = "labelFileCoping";
            this.labelFileCoping.Size = new System.Drawing.Size(123, 13);
            this.labelFileCoping.TabIndex = 5;
            this.labelFileCoping.Text = "Процесс копирования:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(12, 205);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(127, 44);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopyClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(145, 205);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(127, 44);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExitClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.labelFileCoping);
            this.Controls.Add(this.progressBarFileCoping);
            this.Controls.Add(this.textBoxFileDirectorySave);
            this.Controls.Add(this.labelFileDirectorySave);
            this.Controls.Add(this.textBoxFileDirectoryOpen);
            this.Controls.Add(this.labelFileDirectoryOpen);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FormMain";
            this.Text = "Домашняя работа #2.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileDirectoryOpen;
        private System.Windows.Forms.TextBox textBoxFileDirectoryOpen;
        private System.Windows.Forms.TextBox textBoxFileDirectorySave;
        private System.Windows.Forms.Label labelFileDirectorySave;
        private System.Windows.Forms.ProgressBar progressBarFileCoping;
        private System.Windows.Forms.Label labelFileCoping;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

