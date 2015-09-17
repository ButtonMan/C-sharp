namespace UsingControlLabel
{
    partial class MyForm
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
            this.MyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MyLabel
            // 
            this.MyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyLabel.Location = new System.Drawing.Point(0, 0);
            this.MyLabel.Name = "MyLabel";
            this.MyLabel.Size = new System.Drawing.Size(284, 261);
            this.MyLabel.TabIndex = 0;
            this.MyLabel.Text = "Деменострация применения контроллера Label";
            this.MyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MyLabel);
            this.Name = "MyForm";
            this.Text = "Работа с Label";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MyLabel;
    }
}

