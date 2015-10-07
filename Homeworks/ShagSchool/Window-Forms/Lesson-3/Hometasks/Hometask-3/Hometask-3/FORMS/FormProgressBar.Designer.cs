namespace Hometask_3.Forms
{
    partial class FormProgressBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarOpenFile = new System.Windows.Forms.ProgressBar();
            this.labelProgessBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarOpenFile
            // 
            this.progressBarOpenFile.Location = new System.Drawing.Point(12, 29);
            this.progressBarOpenFile.Name = "progressBarOpenFile";
            this.progressBarOpenFile.Size = new System.Drawing.Size(300, 35);
            this.progressBarOpenFile.TabIndex = 0;
            // 
            // labelProgessBar
            // 
            this.labelProgessBar.AutoSize = true;
            this.labelProgessBar.Location = new System.Drawing.Point(9, 13);
            this.labelProgessBar.Name = "labelProgessBar";
            this.labelProgessBar.Size = new System.Drawing.Size(146, 13);
            this.labelProgessBar.TabIndex = 1;
            this.labelProgessBar.Text = "Прогесс загрузки файла ...";
            // 
            // FormProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(324, 90);
            this.Controls.Add(this.labelProgessBar);
            this.Controls.Add(this.progressBarOpenFile);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Открытие документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarOpenFile;
        private System.Windows.Forms.Label labelProgessBar;
    }
}