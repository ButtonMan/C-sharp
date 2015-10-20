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

namespace BasicWorks_ListView
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSetFolder_Click(object sender, EventArgs e)
        {
            DialogResult dialogRisult;
            dialogRisult = this.folderBrowserDialog.ShowDialog();

            if(dialogRisult == DialogResult.OK)
            {
                ImageList largeImageList = null;
                largeImageList = new ImageList();

                this.listView.Clear();
                this.listView.View = View.Details;
                this.listView.Columns.Add("Имя");
                this.listView.Columns.Add("Дата Создания");
                this.listView.Columns.Add("Директория");

                string pathToFolder = null;
                pathToFolder = this.folderBrowserDialog.SelectedPath;

                DirectoryInfo directoryInfo = null;
                directoryInfo = new DirectoryInfo(pathToFolder);

                DirectoryInfo[] directoryInfoArray = null;
                directoryInfoArray = directoryInfo.GetDirectories();

                FileInfo[] fileInfoArray = null;
                fileInfoArray = directoryInfo.GetFiles();
                
                foreach(DirectoryInfo subDirectory in directoryInfoArray)
                {
                    ListViewItem item = null;
                    item = this.listView.Items.Add(subDirectory.Name);
                    item.SubItems.Add(subDirectory.CreationTime.ToShortDateString());
                    item.SubItems.Add(subDirectory.Parent.FullName);
                }
            }

        }
    }
}
