using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UsingLabelWithImage
{
    class MyForm : Form
    {
        Label LabelTxt;
        Image LabelImg;

        public MyForm()
        {
            //
            //LabelImg
            //
            this.LabelImg = Image.FromFile(@"D:\Женя\ДИЗАЙНЫ\8073eb67a907e037a3e39c37690a01dd.jpg");
            //
            //MyForm
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(LabelImg.Width, LabelImg.Height);
            this.Text = "Using control LABEL with image:";
            this.Icon = SystemIcons.WinLogo;
            //
            //LabelTxt
            //
            LabelTxt = new Label();
            LabelTxt.Text = "Пример использования контроллера Labrl" +
                "с изображением";
            this.LabelTxt.TextAlign = ContentAlignment.MiddleCenter;
            LabelTxt.Size = new Size(LabelImg.Width, LabelImg.Height);
            this.LabelTxt.Image = this.LabelImg;
            this.Controls.Add(this.LabelTxt);

        }
    }
}
