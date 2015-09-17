namespace UsingTimeSpan
{
    partial class MyDay
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
            this.components = new System.ComponentModel.Container();
            this.InfoTxt = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // InfoTxt
            // 
            this.InfoTxt.AutoSize = true;
            this.InfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.InfoTxt.Location = new System.Drawing.Point(90, 68);
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.Size = new System.Drawing.Size(66, 16);
            this.InfoTxt.TabIndex = 1;
            this.InfoTxt.Text = "time left:";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.BackColor = System.Drawing.Color.Transparent;
            this.hours.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hours.ForeColor = System.Drawing.Color.Gainsboro;
            this.hours.Location = new System.Drawing.Point(44, 68);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(149, 117);
            this.hours.TabIndex = 1;
            this.hours.Text = "23";
            // 
            // minutes
            // 
            this.minutes.BackColor = System.Drawing.Color.Transparent;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutes.ForeColor = System.Drawing.Color.Gainsboro;
            this.minutes.Location = new System.Drawing.Point(162, 78);
            this.minutes.Margin = new System.Windows.Forms.Padding(0);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(80, 46);
            this.minutes.TabIndex = 3;
            this.minutes.Text = "59";
            // 
            // seconds
            // 
            this.seconds.BackColor = System.Drawing.Color.Transparent;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seconds.ForeColor = System.Drawing.Color.Gainsboro;
            this.seconds.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.seconds.Location = new System.Drawing.Point(162, 123);
            this.seconds.Margin = new System.Windows.Forms.Padding(0);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(80, 46);
            this.seconds.TabIndex = 4;
            this.seconds.Text = "59";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.ShowTime);
            // 
            // MyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.InfoTxt);
            this.Controls.Add(this.hours);
            this.Name = "MyDay";
            this.Text = "Using TimeSpan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoTxt;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label seconds;
        protected System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Timer timer;
    }
}

