namespace Hometask_3.Forms
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
            this.richTextBoxDocument = new System.Windows.Forms.RichTextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonEdite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxDocument
            // 
            this.richTextBoxDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDocument.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBoxDocument.Location = new System.Drawing.Point(13, 13);
            this.richTextBoxDocument.Name = "richTextBoxDocument";
            this.richTextBoxDocument.ReadOnly = true;
            this.richTextBoxDocument.Size = new System.Drawing.Size(259, 236);
            this.richTextBoxDocument.TabIndex = 1;
            this.richTextBoxDocument.Text = "";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonDownload.ForeColor = System.Drawing.Color.White;
            this.buttonDownload.Location = new System.Drawing.Point(13, 255);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(126, 37);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Загрузить";
            this.buttonDownload.UseVisualStyleBackColor = false;
            // 
            // buttonEdite
            // 
            this.buttonEdite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdite.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonEdite.Enabled = false;
            this.buttonEdite.ForeColor = System.Drawing.Color.White;
            this.buttonEdite.Location = new System.Drawing.Point(146, 255);
            this.buttonEdite.Name = "buttonEdite";
            this.buttonEdite.Size = new System.Drawing.Size(126, 37);
            this.buttonEdite.TabIndex = 2;
            this.buttonEdite.Text = "Редактировать";
            this.buttonEdite.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(284, 304);
            this.Controls.Add(this.buttonEdite);
            this.Controls.Add(this.richTextBoxDocument);
            this.Controls.Add(this.buttonDownload);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнее задание №3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDocument;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonEdite;
    }
}

