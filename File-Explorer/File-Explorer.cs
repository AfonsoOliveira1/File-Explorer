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
        public List<string> pathsTodos = new List<string>();
        int indexpath = -1;
        public FileExplorer()
        {
            InitializeComponent();
        }
        private void CloneTabContent(TabPage source, TabPage destination)
        {
            foreach (Control ctrl in source.Controls)
            {
                Control copy = (Control)Activator.CreateInstance(ctrl.GetType());

                copy.Name = ctrl.Name;
                copy.Text = ctrl.Text;
                copy.Size = ctrl.Size;
                copy.Location = ctrl.Location;
                copy.Anchor = ctrl.Anchor;
                copy.Dock = ctrl.Dock;

                destination.Controls.Add(copy);
                tcMain.TabPages.Add(destination);
                destination.Focus();
            }
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
                node.ImageIndex = node.SelectedImageIndex = 3;
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
        private TreeNode FindNodeByTag(TreeNodeCollection nodes, string tag)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag?.ToString().Equals(tag, StringComparison.OrdinalIgnoreCase) == true)//sem diff em maiusculas e minusculas
                    return node;

                var found = FindNodeByTag(node.Nodes, tag);//recursão bem boa para todos os niveis da treeNode
                if (found != null)
                    return found;
            }
            return null;
        }
        private void FileExplorer_Load(object sender, EventArgs e)
        {
            PopularTreeView();
            lblItens.Text = "";
            lblItensSelected.Text = "";
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
                    if(subNode.Level != 0)
                        subNode.ImageIndex = node.SelectedImageIndex = 0;
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
                    string ext = new FileInfo(file).Extension.ToString();
                    item.SubItems.Add(ext);
                    if(ext== ".txt")
                    {
                        item.ImageIndex = 1;
                    }
                    else if(ext == ".png" || ext == ".jpg" || ext == ".gif")
                    {
                        item.ImageIndex = 2;
                    }
                    else if(ext == ".zip" || ext == ".rar")
                    {
                        item.ImageIndex = 4;
                    }
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
                    item.SubItems.Add("Pasta de ficheiros");
                    item.SubItems.Add("");
                    item.ImageIndex = 0;
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
                TabPage abaNova = new TabPage("File Explorer");
                CloneTabContent(tcMain.TabPages[tcMain.TabPages.Count - 1], abaNova);
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
                lvMain.Items.Remove(item);
                var tn = FindNodeByTag(tvMain.Nodes, path);
                if(tn != null)
                tvMain.Nodes.Remove(tn);
            }
        }

        private void pbRename_Click(object sender, EventArgs e)
        {
            if(lvMain.SelectedItems.Count > 0)
            {
                ListViewItem item = lvMain.SelectedItems[0];
                lvMain.LabelEdit = true;
                item.BeginEdit();
            }
        }

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMain.SelectedItems.Count > 0)
            {
                txtPath.Text = lvMain.SelectedItems[0].Tag.ToString();
                if(lvMain.SelectedItems.Count == 1)
                    lblItensSelected.Text = "1 item selecionado |";
                else if(lvMain.SelectedItems.Count == 0) lblItensSelected.Text = "";
                else lblItensSelected.Text = lvMain.SelectedItems.Count + " itens selecionados |";
                pbRemove.Enabled = true;
                pbRename.Enabled = true;
            }
            else
            {
                pbRename.Enabled = false;
                pbRemove.Enabled = false;
            }
        }

        private void txtPath_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string path = txtPath.Text;
                TreeNode node = FindNodeByTag(tvMain.Nodes, path);

                if (node != null)
                {
                    tvMain.SelectedNode = node;
                    node.EnsureVisible();
                    node.Expand();
                }

                foreach (ListViewItem item in lvMain.Items)
                {
                    if (item.Tag?.ToString() == path)
                    {
                        item.Selected = true;
                        item.EnsureVisible();
                        lvMain.Focus();
                        break;
                    }
                }
            }
        }

        private void tvMain_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            int count = 0;
            TreeNode node = e.Node;
            try
            {
                string[] directories = Directory.GetDirectories(node.Tag.ToString());
                foreach (var directorie in directories)
                {
                    count++;
                }
                lblItens.Text = count + " itens |";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um Erro ocorreu com " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtPath.Text = tvMain.SelectedNode.Tag.ToString();
            pathsTodos.Add(txtPath.Text);
            indexpath++;
            updateButoes();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            indexpath--;
            atualNode(pathsTodos[indexpath]);
            updateButoes();
        }

        private void btnDepois_Click(object sender, EventArgs e)
        {
            indexpath++;
            atualNode(pathsTodos[indexpath]);
            updateButoes();
        }

        private void atualNode(string path)
        {
            var node = FindNodeByTag(tvMain.Nodes, path);
            if (node != null)
            {
                tvMain.SelectedNode = node;
                node.EnsureVisible();
                txtPath.Text = path;
            }
        }
        private void updateButoes()
        {
            btnAnterior.Enabled = indexpath > 0;
            btnDepois.Enabled = indexpath < pathsTodos.Count - 1;
        }

        private void lvMain_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;

            ListViewItem item = lvMain.Items[e.Item];
            string oldPath = item.Tag.ToString();
            string directory = Path.GetDirectoryName(oldPath);
            string newPath = Path.Combine(directory, e.Label);

            try
            {
                if (File.Exists(newPath) || Directory.Exists(newPath))
                {
                    MessageBox.Show("Já existe um ficheiro/pasta com esse nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.CancelEdit = true;
                    return;
                }

                if (File.Exists(oldPath))
                {
                    File.Move(oldPath, newPath);
                }
                else if (Directory.Exists(oldPath))
                {
                    Directory.Move(oldPath, newPath);
                }

                item.Tag = newPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
            }
        }
    }
}
