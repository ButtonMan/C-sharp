using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWorks_DrugAndDrop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetRichTextBox();
            EventSubscriptions();
        }

        private void SetRichTextBox()
        {
            this.richTextBox.AllowDrop = true;
        }

        private void EventSubscriptions()
        {
            this.richTextBox.DragDrop += new DragEventHandler(RichTextBoxDragDrop);
        }

        private void RichTextBoxDragDrop(Object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];

                try
                {
                    foreach (string path in filePaths)
                    {
                        if (File.Exists(path))
                        {
                            try
                            {
                                this.richTextBox.Rtf = (File.ReadAllText(path) +
                                    Environment.NewLine);
                            }
                            catch (ArgumentException)
                            {
                                MessageBox.Show("Файл небыл открыт! Формат выбранного файла не "
                                    + "поддерживается. ");
                            }
                            catch (IOException)
                            {
                                MessageBox.Show("При загрузке файла, произошла ошибка. " +
                                    "Повторите попытку еще раз.");
                            }

                        }
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Файл небыл открыт! Проверьте, существует ли " +
                        "указанный вами файл");
                }
            }
        }
    }
}
