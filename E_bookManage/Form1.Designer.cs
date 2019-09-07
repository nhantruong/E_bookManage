namespace E_bookManage
{
    partial class frm_EbookManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EbookManage));
            this.dgv_ebooks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Catalogue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_EbookManage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_LoadList = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.chudeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_RenameFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ebooks)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chudeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ebooks
            // 
            this.dgv_ebooks.AllowUserToAddRows = false;
            this.dgv_ebooks.AllowUserToDeleteRows = false;
            this.dgv_ebooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ebooks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_ebooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NamXB,
            this.TenFile,
            this.TenSach,
            this.Tag,
            this.cmb_Catalogue,
            this.link});
            this.dgv_ebooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ebooks.GridColor = System.Drawing.Color.Black;
            this.dgv_ebooks.Location = new System.Drawing.Point(3, 16);
            this.dgv_ebooks.Name = "dgv_ebooks";
            this.dgv_ebooks.Size = new System.Drawing.Size(883, 546);
            this.dgv_ebooks.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            // 
            // NamXB
            // 
            this.NamXB.HeaderText = "Năm XB";
            this.NamXB.MinimumWidth = 50;
            this.NamXB.Name = "NamXB";
            // 
            // TenFile
            // 
            this.TenFile.HeaderText = "Tên file";
            this.TenFile.MinimumWidth = 30;
            this.TenFile.Name = "TenFile";
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 50;
            this.TenSach.Name = "TenSach";
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.MinimumWidth = 30;
            this.Tag.Name = "Tag";
            // 
            // cmb_Catalogue
            // 
            this.cmb_Catalogue.HeaderText = "Catalogue";
            this.cmb_Catalogue.MinimumWidth = 40;
            this.cmb_Catalogue.Name = "cmb_Catalogue";
            // 
            // link
            // 
            this.link.HeaderText = "Link to file";
            this.link.Name = "link";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.StatusProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 17);
            this.lblStatus.Text = "...";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.Image = global::E_bookManage.Properties.Resources.Open_file;
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.selectFolderToolStripMenuItem.Text = "Select Folder";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::E_bookManage.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Image = global::E_bookManage.Properties.Resources.Pinion;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::E_bookManage.Properties.Resources.Find;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_EbookManage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 565);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Panel";
            // 
            // btn_EbookManage
            // 
            this.btn_EbookManage.AutoSize = true;
            this.btn_EbookManage.BackColor = System.Drawing.Color.LightGray;
            this.btn_EbookManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EbookManage.ForeColor = System.Drawing.Color.Black;
            this.btn_EbookManage.Image = global::E_bookManage.Properties.Resources.Check_boxes;
            this.btn_EbookManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EbookManage.Location = new System.Drawing.Point(3, 16);
            this.btn_EbookManage.Name = "btn_EbookManage";
            this.btn_EbookManage.Size = new System.Drawing.Size(139, 38);
            this.btn_EbookManage.TabIndex = 0;
            this.btn_EbookManage.Text = "Ebooks Manage";
            this.btn_EbookManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EbookManage.UseVisualStyleBackColor = false;
            this.btn_EbookManage.Click += new System.EventHandler(this.btn_EbookManage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgv_ebooks);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(145, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 565);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List ebooks";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_RenameFile);
            this.groupBox3.Controls.Add(this.btn_LoadList);
            this.groupBox3.Controls.Add(this.btn_Save);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(883, 61);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btn_LoadList
            // 
            this.btn_LoadList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LoadList.Image = global::E_bookManage.Properties.Resources.Scenario;
            this.btn_LoadList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoadList.Location = new System.Drawing.Point(78, 16);
            this.btn_LoadList.Name = "btn_LoadList";
            this.btn_LoadList.Size = new System.Drawing.Size(100, 42);
            this.btn_LoadList.TabIndex = 2;
            this.btn_LoadList.Text = "&Danh sách";
            this.btn_LoadList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LoadList.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.AllowDrop = true;
            this.btn_Save.AutoSize = true;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Save.Image = global::E_bookManage.Properties.Resources.Save;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(3, 16);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 42);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // chudeBindingSource
            // 
            this.chudeBindingSource.DataSource = typeof(EbookManage.Data.ebook.Chude);
            // 
            // btn_RenameFile
            // 
            this.btn_RenameFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_RenameFile.Image = global::E_bookManage.Properties.Resources.Pinion;
            this.btn_RenameFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RenameFile.Location = new System.Drawing.Point(178, 16);
            this.btn_RenameFile.Name = "btn_RenameFile";
            this.btn_RenameFile.Size = new System.Drawing.Size(133, 42);
            this.btn_RenameFile.TabIndex = 3;
            this.btn_RenameFile.Text = "Đổi tên File ebook";
            this.btn_RenameFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RenameFile.UseVisualStyleBackColor = true;
            this.btn_RenameFile.Click += new System.EventHandler(this.btn_RenameFile_Click);
            // 
            // frm_EbookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_EbookManage";
            this.Text = "Ebook Manage";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ebooks)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chudeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ebooks;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.BindingSource chudeBindingSource;
        private System.Windows.Forms.Button btn_EbookManage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_LoadList;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmb_Catalogue;
        private System.Windows.Forms.DataGridViewLinkColumn link;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private System.Windows.Forms.Button btn_RenameFile;
    }
}

