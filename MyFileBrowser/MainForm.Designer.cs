
namespace MyFileBrowser
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LST_Sequences = new System.Windows.Forms.ListBox();
            this.MySeqData = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.MyFolderBox = new System.Windows.Forms.TextBox();
            this.MyLoadedImages = new System.Windows.Forms.ImageList(this.components);
            this.LBL_Status = new System.Windows.Forms.Label();
            this.MyFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LST_Formats = new System.Windows.Forms.CheckedListBox();
            this.P_boxA = new System.Windows.Forms.PictureBox();
            this.P_boxB = new System.Windows.Forms.PictureBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MySeqData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxB)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Image = ((System.Drawing.Image)(resources.GetObject("btn_load.Image")));
            this.btn_load.Location = new System.Drawing.Point(887, 321);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(120, 42);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Pick Folder";
            this.btn_load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LST_Sequences);
            this.groupBox1.Controls.Add(this.MySeqData);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.MyFolderBox);
            this.groupBox1.Controls.Add(this.btn_load);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Data ";
            // 
            // LST_Sequences
            // 
            this.LST_Sequences.FormattingEnabled = true;
            this.LST_Sequences.ItemHeight = 15;
            this.LST_Sequences.Location = new System.Drawing.Point(20, 35);
            this.LST_Sequences.Name = "LST_Sequences";
            this.LST_Sequences.ScrollAlwaysVisible = true;
            this.LST_Sequences.Size = new System.Drawing.Size(482, 259);
            this.LST_Sequences.TabIndex = 9;
            // 
            // MySeqData
            // 
            this.MySeqData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MySeqData.Location = new System.Drawing.Point(556, 35);
            this.MySeqData.Name = "MySeqData";
            this.MySeqData.ReadOnly = true;
            this.MySeqData.RowTemplate.Height = 25;
            this.MySeqData.Size = new System.Drawing.Size(599, 268);
            this.MySeqData.TabIndex = 8;
            this.MySeqData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MySeqData_CellClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(1013, 321);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(120, 42);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.BTN_refresh_Click);
            // 
            // MyFolderBox
            // 
            this.MyFolderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MyFolderBox.Location = new System.Drawing.Point(20, 321);
            this.MyFolderBox.Name = "MyFolderBox";
            this.MyFolderBox.Size = new System.Drawing.Size(831, 23);
            this.MyFolderBox.TabIndex = 2;
            // 
            // MyLoadedImages
            // 
            this.MyLoadedImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.MyLoadedImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyLoadedImages.ImageStream")));
            this.MyLoadedImages.TransparentColor = System.Drawing.Color.Transparent;
            this.MyLoadedImages.Images.SetKeyName(0, "btn_image.png");
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Location = new System.Drawing.Point(12, 24);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(39, 15);
            this.LBL_Status.TabIndex = 7;
            this.LBL_Status.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.AboutToolStripMenuItem1});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.AboutToolStripMenuItem.Text = "File";
            // 
            // OpenFolderToolStripMenuItem
            // 
            this.OpenFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem";
            this.OpenFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFolderToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.OpenFolderToolStripMenuItem.Text = "Open Folder";
            this.OpenFolderToolStripMenuItem.ToolTipText = "Open folder source ";
            this.OpenFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // AboutToolStripMenuItem1
            // 
            this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
            this.AboutToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.AboutToolStripMenuItem1.Text = "About";
            this.AboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // LST_Formats
            // 
            this.LST_Formats.FormattingEnabled = true;
            this.LST_Formats.Items.AddRange(new object[] {
            ".png",
            "*.jpg",
            ".gif",
            ".bmp"});
            this.LST_Formats.Location = new System.Drawing.Point(1015, 504);
            this.LST_Formats.Name = "LST_Formats";
            this.LST_Formats.Size = new System.Drawing.Size(162, 94);
            this.LST_Formats.TabIndex = 8;
            // 
            // P_boxA
            // 
            this.P_boxA.Location = new System.Drawing.Point(433, 516);
            this.P_boxA.Name = "P_boxA";
            this.P_boxA.Size = new System.Drawing.Size(131, 102);
            this.P_boxA.TabIndex = 9;
            this.P_boxA.TabStop = false;
            // 
            // P_boxB
            // 
            this.P_boxB.Location = new System.Drawing.Point(638, 504);
            this.P_boxB.Name = "P_boxB";
            this.P_boxB.Size = new System.Drawing.Size(151, 114);
            this.P_boxB.TabIndex = 10;
            this.P_boxB.TabStop = false;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "STS_Strip";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 660);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.P_boxB);
            this.Controls.Add(this.P_boxA);
            this.Controls.Add(this.LST_Formats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Status);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MySeqData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MyFolderBox;
        private System.Windows.Forms.FolderBrowserDialog MyFolderBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem1;
        private System.Windows.Forms.ImageList MyLoadedImages;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.CheckedListBox LST_Formats;
        private System.Windows.Forms.DataGridView MySeqData;
        private System.Windows.Forms.PictureBox P_boxA;
        private System.Windows.Forms.PictureBox P_boxB;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ListBox LST_Sequences;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

