namespace Hometask_2.Forms
{
    partial class FormResult
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
            this.labelPersonDataInfo = new System.Windows.Forms.Label();
            this.labelPersonDataResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPersonDataInfo
            // 
            this.labelPersonDataInfo.AutoSize = true;
            this.labelPersonDataInfo.Location = new System.Drawing.Point(27, 34);
            this.labelPersonDataInfo.Name = "labelPersonDataInfo";
            this.labelPersonDataInfo.Size = new System.Drawing.Size(119, 13);
            this.labelPersonDataInfo.TabIndex = 0;
            this.labelPersonDataInfo.Text = "Данные респондента:";
            // 
            // labelPersonDataResult
            // 
            this.labelPersonDataResult.AutoSize = true;
            this.labelPersonDataResult.Location = new System.Drawing.Point(27, 57);
            this.labelPersonDataResult.Name = "labelPersonDataResult";
            this.labelPersonDataResult.Size = new System.Drawing.Size(51, 13);
            this.labelPersonDataResult.TabIndex = 1;
            this.labelPersonDataResult.Text = "-данные-";
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelPersonDataResult);
            this.Controls.Add(this.labelPersonDataInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPersonDataInfo;
        private System.Windows.Forms.Label labelPersonDataResult;
    }
}