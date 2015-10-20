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

namespace BasicWork_TreeView
{
    public partial class FormMain : Form
    {
        string pathToRootFolder = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            this.treeView.Nodes.Clear();

            this.folderBrowserDialog = new FolderBrowserDialog();

            DialogResult dialogResult;
            dialogResult = this.folderBrowserDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                this.pathToRootFolder = this.folderBrowserDialog.SelectedPath;

                string nodeName = null;
                nodeName = Path.GetFileName(this.pathToRootFolder);
                if (String.IsNullOrEmpty(nodeName)) nodeName = this.pathToRootFolder;
                TreeNode rootNode = null;
                rootNode = this.treeView.Nodes.Add(nodeName);

                DirectoryInfo rootDirectoryInfo = null;
                rootDirectoryInfo = new DirectoryInfo(this.pathToRootFolder);

                this.FillTreeView(rootNode, rootDirectoryInfo);
            }
        }

        private void FillTreeView(TreeNode rootNode, DirectoryInfo rootDirectoryInfo)
        {
            //информация о вложенных папках
            DirectoryInfo[] directoryInfoArray = null;
            try
            {
                directoryInfoArray = rootDirectoryInfo.GetDirectories();
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
            catch(DirectoryNotFoundException)
            {
                return;
            }

            //информация о вложенных файлах
            FileInfo[] fileInfoArray = null;
            fileInfoArray = rootDirectoryInfo.GetFiles();

            foreach (DirectoryInfo directory in directoryInfoArray)
            {
                TreeNode node = null;
                node = rootNode.Nodes.Add(directory.Name);

                DirectoryInfo directoryInfo = null;
                directoryInfo = new DirectoryInfo(directory.FullName);

                this.FillTreeView(node, directoryInfo);
            }
            foreach (FileInfo file in fileInfoArray)
            {
                rootNode.Nodes.Add(file.Name);
            }
        }
    }
}
