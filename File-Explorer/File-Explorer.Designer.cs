namespace File_Explorer
{
    partial class FileExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRename = new System.Windows.Forms.PictureBox();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.btnDepois = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblItensSelected = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            this.panel4.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pbRename);
            this.panel1.Controls.Add(this.pbRemove);
            this.panel1.Controls.Add(this.btnDepois);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 49);
            this.panel1.TabIndex = 0;
            // 
            // pbRename
            // 
            this.pbRename.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbRename.Enabled = false;
            this.pbRename.Image = global::File_Explorer.Properties.Resources._5136886;
            this.pbRename.Location = new System.Drawing.Point(299, 0);
            this.pbRename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRename.Name = "pbRename";
            this.pbRename.Size = new System.Drawing.Size(68, 49);
            this.pbRename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRename.TabIndex = 8;
            this.pbRename.TabStop = false;
            this.pbRename.Click += new System.EventHandler(this.pbRename_Click);
            // 
            // pbRemove
            // 
            this.pbRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbRemove.Enabled = false;
            this.pbRemove.Image = global::File_Explorer.Properties.Resources._860829;
            this.pbRemove.Location = new System.Drawing.Point(231, 0);
            this.pbRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(68, 49);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemove.TabIndex = 7;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // btnDepois
            // 
            this.btnDepois.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepois.Enabled = false;
            this.btnDepois.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDepois.Location = new System.Drawing.Point(116, 0);
            this.btnDepois.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepois.Name = "btnDepois";
            this.btnDepois.Size = new System.Drawing.Size(115, 49);
            this.btnDepois.TabIndex = 6;
            this.btnDepois.Text = ">";
            this.btnDepois.UseVisualStyleBackColor = true;
            this.btnDepois.Click += new System.EventHandler(this.btnDepois_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAnterior.Location = new System.Drawing.Point(0, 0);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(116, 49);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(373, 12);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(491, 22);
            this.txtPath.TabIndex = 3;
            this.txtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(411, 375);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 273);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tcMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1127, 583);
            this.panel4.TabIndex = 3;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcMain.Name = "tcMain";
            this.tcMain.Padding = new System.Drawing.Point(20, 4);
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1127, 583);
            this.tcMain.TabIndex = 1;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1119, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.lblItensSelected);
            this.panel6.Controls.Add(this.lblItens);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 517);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1113, 33);
            this.panel6.TabIndex = 3;
            // 
            // lblItensSelected
            // 
            this.lblItensSelected.AutoSize = true;
            this.lblItensSelected.Location = new System.Drawing.Point(69, 9);
            this.lblItensSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItensSelected.Name = "lblItensSelected";
            this.lblItensSelected.Size = new System.Drawing.Size(44, 16);
            this.lblItensSelected.TabIndex = 1;
            this.lblItensSelected.Text = "label1";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Location = new System.Drawing.Point(8, 9);
            this.lblItens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(44, 16);
            this.lblItens.TabIndex = 0;
            this.lblItens.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lvMain);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 51);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1113, 499);
            this.panel5.TabIndex = 2;
            // 
            // lvMain
            // 
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Data,
            this.Tipo,
            this.Tamanho});
            this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMain.HideSelection = false;
            this.lvMain.Location = new System.Drawing.Point(333, 0);
            this.lvMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(780, 499);
            this.lvMain.SmallImageList = this.imageList1;
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvMain_AfterLabelEdit);
            this.lvMain.SelectedIndexChanged += new System.EventHandler(this.lvMain_SelectedIndexChanged);
            this.lvMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMain_MouseDoubleClick);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // Data
            // 
            this.Data.Text = "Data de Modificação";
            this.Data.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 110;
            // 
            // Tamanho
            // 
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.Width = 120;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder-223.png");
            this.imageList1.Images.SetKeyName(1, "txticon.png");
            this.imageList1.Images.SetKeyName(2, "imageicon.png");
            this.imageList1.Images.SetKeyName(3, "disc.jpeg");
            this.imageList1.Images.SetKeyName(4, "ZIPFILE.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 499);
            this.panel2.TabIndex = 1;
            // 
            // tvMain
            // 
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.ImageIndex = 0;
            this.tvMain.ImageList = this.imageList1;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvMain.Name = "tvMain";
            this.tvMain.SelectedImageIndex = 0;
            this.tvMain.Size = new System.Drawing.Size(333, 499);
            this.tvMain.TabIndex = 0;
            this.tvMain.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvMain_BeforeExpand);
            this.tvMain.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterSelect);
            this.tvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterSelect_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1119, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 583);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.FileExplorer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Button btnDepois;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.PictureBox pbRename;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.Label lblItensSelected;
    }
}

