using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileBrowser
{
    public partial class Form1 : Form
    {
        
        private string DirectoryPath;
        private string SelectedDirectoryPath;
        private string SelectedFileName;
        private DirectoryInfo[] Dirs;
        private DirectoryInfo Dir;
        private FileInfo[] Files;
        
        private int DirsCount;
        private int FilesCount;
            
        public Form1()
        {
            
            InitializeComponent();
        }
        private void ParseInnerNode(TreeNode node,string DirectoryPath )
        {
            DirectoryInfo dir = new DirectoryInfo(DirectoryPath);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            for(int i=0;i<dirs.Length;i++)
            {
                TreeNode currentNode = new TreeNode(dirs[i].Name, 1, 1);
                node.Nodes.Add(currentNode);
                ParseInnerNode(currentNode, dirs[i].FullName);
            }
            //循环文件
            for (int i = 0; i < files.Length; i++)
            {
                node.Nodes.Add(files[i].Name);
            }
        }
        private void PaintTreeView()
        {
            DirectorytreeView.Nodes.Clear();
            this.SelectedDirectoryPath = this.DirectoryPath;
            this.Dir = new DirectoryInfo(DirectoryPath);
            this.Dirs = this.Dir.GetDirectories();
            this.Files = this.Dir.GetFiles();
            this.DirsCount = this.Dirs.Length;
            this.FilesCount = this.Files.Length;
            //循环文件夹
            for (int i = 0; i < DirsCount; i++)
            {
                DirectorytreeView.Nodes.Add(new TreeNode(Dirs[i].Name,1,1));
                
                ParseInnerNode(DirectorytreeView.Nodes[i], Dirs[i].FullName);
            }

            //循环文件
            for (int i = 0; i < FilesCount; i++)
            {
                DirectorytreeView.Nodes.Add(Files[i].Name);
            }
            PaintListView(this.DirectoryPath);
        }
        private void RootDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.Description = "请选择根目录";
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                {
                    MessageBox.Show("文件夹路径不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                this.DirectoryPath = folderBrowserDialog1.SelectedPath;//存储文件的路径信息
            }
            PaintTreeView();
        }
        private void GetFullPath(TreeNode node)
        {
            string a = node.Text;
            while(node.Parent!=null)
            {
                a = node.Parent.Text+"\\"+a;
                node = node.Parent;
            }
            this.SelectedDirectoryPath = this.DirectoryPath + "\\" + a;
            
        }
        private void PaintListView(string selectedPath)
        {
            this.listView1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(selectedPath);
            DirectoryInfo[] Dirs = dir.GetDirectories();
            FileInfo[] Files = dir.GetFiles();
            int DirsCount = Dirs.Length;
            int FilesCount = Files.Length;
            for(int i=0;i<DirsCount;i++)
            {
                //this.listView1.Items.Add(new ListViewItem())
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = 1;     //通过与imageList绑定，显示imageList中第i项图标

                lvi.Text = Dirs[i].Name;

                this.listView1.Items.Add(lvi);
            }
            for (int i = 0; i < FilesCount; i++)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = 0;     //通过与imageList绑定，显示imageList中第i项图标

                lvi.Text = Files[i].Name;

                this.listView1.Items.Add(lvi);
            }

        }
        private void DirectorytreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //switch ((e.Action))
            //{
            //    case TreeViewAction.ByKeyboard:
            //        MessageBox.Show("You like the keyboard!");
            //        break;
            //    case TreeViewAction.ByMouse:
            //        MessageBox.Show("You like the mouse!");
            //        break;
            //}
            //Example From Microsoft Documentation
            switch((e.Node.ImageIndex))
            {
                case 1:
                    //this.SelectedDirectoryPath = e.Node.Name;
                    GetFullPath(e.Node);
                    PaintListView(this.SelectedDirectoryPath);
                    break;
                case 0:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.imageList1.Images.Add(IconResource.icons8_file_26px);
            this.imageList1.Images.Add(IconResource.icons8_directory_16px);
            this.DirectorytreeView.ImageList = imageList1;
            this.listView1.SmallImageList = imageList1;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //switch (listView1.SelectedItems[0].text)
            //{
            //    case 
            //}
            //Example Code
            this.SelectedFileName = this.SelectedDirectoryPath + "\\" + listView1.SelectedItems[0].Text;
            //MessageBox.Show(this.SelectedFileName);
            if (listView1.SelectedItems[0].Text.EndsWith(".txt"))
            {
                System.Diagnostics.Process.Start("notepad.exe", this.SelectedFileName);
            }
            else if(listView1.SelectedItems[0].Text.EndsWith(".exe"))
            {
                if (File.Exists(SelectedFileName))
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo(SelectedFileName);
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.CreateNoWindow = true;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit(2000);
                    string output = process.StandardOutput.ReadToEnd();

                    process.Close();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
