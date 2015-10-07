namespace Hometask_3.Forms
{
    partial class FormTextEdit
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
            this.buttonCansel = new System.Windows.Forms.Button();
            this.richTextBoxEdit = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCansel
            // 
            this.buttonCansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCansel.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonCansel.ForeColor = System.Drawing.Color.White;
            this.buttonCansel.Location = new System.Drawing.Point(446, 263);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(126, 37);
            this.buttonCansel.TabIndex = 5;
            this.buttonCansel.Text = "Отменить";
            this.buttonCansel.UseVisualStyleBackColor = false;
            // 
            // richTextBoxEdit
            // 
            this.richTextBoxEdit.AcceptsTab = true;
            this.richTextBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxEdit.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBoxEdit.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxEdit.Name = "richTextBoxEdit";
            this.richTextBoxEdit.ShowSelectionMargin = true;
            this.richTextBoxEdit.Size = new System.Drawing.Size(560, 245);
            this.richTextBoxEdit.TabIndex = 4;
            this.richTextBoxEdit.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(305, 263);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 37);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Cохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // FormTextEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 312);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.richTextBoxEdit);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormTextEdit";
            this.Text = "Редактирование текста";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.RichTextBox richTextBoxEdit;
        private System.Windows.Forms.Button buttonSave;
    }
}