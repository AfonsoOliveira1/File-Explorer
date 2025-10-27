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
using System.Xml.Linq;

namespace File_Explorer
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }
        public void CriarTab(TabPage aba)
        {
            TabPage novaAba = new TabPage();

            Panel panelCima = new Panel();
            panelCima.Dock = DockStyle.Top;
            novaAba.Controls.Add(panelCima);
    
            //tree
            Panel panelTree = new Panel();
            panelTree.Dock = DockStyle.Left;
            TreeView tree = new TreeView();
            tree.Dock = DockStyle.Fill;
            panelTree.Controls.Add(tree);
            novaAba.Controls.Add(panelTree);
            string path;
            //list
            Panel panelList = new Panel();
            panelList.Dock = DockStyle.Fill;
            ListView list = new ListView();
            list.Dock = DockStyle.Fill;
            panelList.Controls.Add(list);
            novaAba.Controls.Add(panelList);

            tcMain.TabPages.Insert(tcMain.TabPages.Count - 1,novaAba);
            tcMain.SelectedTab = novaAba;
        }
        public void PopularTreeView()
        {
            tvMain.Nodes.Clear();
            foreach (var drive in Directory.GetLogicalDrives())
            {
                TreeNode node = new TreeNode(drive);
                node.Tag = drive;
                node.Nodes.Add("Loading...");
                tvMain.Nodes.Add(node);
            }
        }
        public string Tamanhos(long tamanho)
        {
            if(tamanho > 1000)
            {
                long kb = tamanho / 1000;
                if(kb > 1000)
                {
                    long mb = kb / 1000;
                    if(mb > 1000)
                    {
                        long gb = mb / 1000;
                        return gb + " GB";
                    }
                    return mb + " MB";
                }
                return kb + " KB";
            }
            return tamanho + " bytes";
        }
        private void FileExplorer_Load(object sender, EventArgs e)
        {
            PopularTreeView();
        }

        private void tvMain_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node; //pega o node selecionado
            node.Nodes.Clear(); //tira o loading
            try
            {
                string[] directories = Directory.GetDirectories(node.Tag.ToString()); //array de todos os subdiretórios
                foreach (string directory in directories)
                {
                    TreeNode subNode = new TreeNode(Path.GetFileName(directory));
                    subNode.Tag = directory;
                    subNode.Nodes.Add("Loading...");
                    node.Nodes.Add(subNode);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Um Erro ocorreu com " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            txtPath.Text = path;
            lvMain.Items.Clear();
            try
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    item.Tag = file;
                    item.SubItems.Add(new FileInfo(file).LastWriteTime.ToString());
                    item.SubItems.Add(new FileInfo(file).Extension.ToString());
                    string size = Tamanhos(new FileInfo(file).Length).ToString();
                    item.SubItems.Add(size);
                    lvMain.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Um Erro ocorreu com " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (string directorie in directories)
                {
                    DirectoryInfo dir = new DirectoryInfo(directorie);
                    ListViewItem item = new ListViewItem(dir.Name);
                    item.Tag = directorie;
                    item.SubItems.Add(new DirectoryInfo(directorie).LastWriteTime.ToString());
                    item.SubItems.Add(new DirectoryInfo(directorie).Extension.ToString());
                    item.SubItems.Add("");
                    lvMain.Items.Add(item);
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Um Erro ocorreu com " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lvMain.SelectedItems.Count > 0)
            {
                string filepath = lvMain.SelectedItems[0].Tag.ToString();
                try
                {
                    System.Diagnostics.Process.Start(filepath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um Erro ocorreu com " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tcMain.TabPages.Count == 1)
            {
                this.Close();
            }

            if(tcMain.SelectedTab.Text == "+")
            {
                if (tcMain.TabPages.Count > 1)
                {
                    TabPage abaAnterior = tcMain.TabPages[tcMain.TabPages.Count - 1];
                    CriarTab(abaAnterior);
                }
                else
                {
                    
                }
            }
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvMain.SelectedItems)
            {
                string path = item.Tag.ToString();
                if(File.Exists(path))
                    File.Delete(path);
                if(Directory.Exists(path))
                    Directory.Delete(path, true);
            }
        }

        private void pbRename_Click(object sender, EventArgs e)
        {

        }

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMain.SelectedItems.Count == 1)
            {
                pbRemove.Enabled = true;
                pbRename.Enabled = true;
            }
            else
            {
                pbRename.Enabled = false;
                pbRemove.Enabled = false;
            }
        }
    }
}
