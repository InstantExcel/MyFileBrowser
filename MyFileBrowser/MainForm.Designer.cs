
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
            this.MySeqData = new System.Windows.Forms.DataGridView();
            this.MyLoadedImages = new System.Windows.Forms.ImageList(this.components);
            this.LBL_Status = new System.Windows.Forms.Label();
            this.MyFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.MyMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsCHK_PNG = new System.Windows.Forms.ToolStripMenuItem();
            this.IsCHK_JPG = new System.Windows.Forms.ToolStripMenuItem();
            this.IsCHK_GIF = new System.Windows.Forms.ToolStripMenuItem();
            this.IsCHK_BMP = new System.Windows.Forms.ToolStripMenuItem();
            this.P_boxA = new System.Windows.Forms.PictureBox();
            this.P_boxB = new System.Windows.Forms.PictureBox();
            this.MySeqListView = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_s_open = new System.Windows.Forms.Button();
            this.LBL_Folder = new System.Windows.Forms.Label();
            this.LBL_DIRECTORY = new System.Windows.Forms.Label();
            this.MyTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IL_FolderIconList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.STS_Base = new System.Windows.Forms.StatusStrip();
            this.STS_LABEL_TEXT = new System.Windows.Forms.ToolStripStatusLabel();
            this.PROG_BAR = new System.Windows.Forms.ToolStripProgressBar();
            this.TAB_VIDEO = new System.Windows.Forms.TabPage();
            this.RTB_MyOutputs = new System.Windows.Forms.RichTextBox();
            this.LBL_RichText = new System.Windows.Forms.Label();
            this.DG_SEQ_SRC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MySeqData)).BeginInit();
            this.MyMainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxB)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.STS_Base.SuspendLayout();
            this.TAB_VIDEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_SEQ_SRC)).BeginInit();
            this.SuspendLayout();
            // 
            // MySeqData
            // 
            this.MySeqData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MySeqData.Location = new System.Drawing.Point(6, 6);
            this.MySeqData.Name = "MySeqData";
            this.MySeqData.ReadOnly = true;
            this.MySeqData.RowTemplate.Height = 25;
            this.MySeqData.Size = new System.Drawing.Size(1174, 322);
            this.MySeqData.TabIndex = 8;
            this.MySeqData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MySeqData_CellClick);
            // 
            // MyLoadedImages
            // 
            this.MyLoadedImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.MyLoadedImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyLoadedImages.ImageStream")));
            this.MyLoadedImages.TransparentColor = System.Drawing.Color.Transparent;
            this.MyLoadedImages.Images.SetKeyName(0, "btn_image.png");
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LBL_Status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Status.Image = global::MyFileBrowser.Properties.Resources.img_lerp;
            this.LBL_Status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LBL_Status.Location = new System.Drawing.Point(16, 590);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(51, 20);
            this.LBL_Status.TabIndex = 7;
            this.LBL_Status.Text = "Status";
            this.LBL_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyMainMenuStrip
            // 
            this.MyMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.MyMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MyMainMenuStrip.Name = "MyMainMenuStrip";
            this.MyMainMenuStrip.Size = new System.Drawing.Size(1203, 24);
            this.MyMainMenuStrip.TabIndex = 2;
            this.MyMainMenuStrip.Text = "menuStrip1";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.AboutToolStripMenuItem1,
            this.exitToolStripMenuItem});
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsCHK_PNG,
            this.IsCHK_JPG,
            this.IsCHK_GIF,
            this.IsCHK_BMP});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // IsCHK_PNG
            // 
            this.IsCHK_PNG.Checked = true;
            this.IsCHK_PNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsCHK_PNG.Name = "IsCHK_PNG";
            this.IsCHK_PNG.Size = new System.Drawing.Size(99, 22);
            this.IsCHK_PNG.Text = "PNG";
            // 
            // IsCHK_JPG
            // 
            this.IsCHK_JPG.Name = "IsCHK_JPG";
            this.IsCHK_JPG.Size = new System.Drawing.Size(99, 22);
            this.IsCHK_JPG.Text = "JPG";
            // 
            // IsCHK_GIF
            // 
            this.IsCHK_GIF.Name = "IsCHK_GIF";
            this.IsCHK_GIF.Size = new System.Drawing.Size(99, 22);
            this.IsCHK_GIF.Text = "GIF";
            this.IsCHK_GIF.Click += new System.EventHandler(this.gFIToolStripMenuItem_Click);
            // 
            // IsCHK_BMP
            // 
            this.IsCHK_BMP.Name = "IsCHK_BMP";
            this.IsCHK_BMP.Size = new System.Drawing.Size(99, 22);
            this.IsCHK_BMP.Text = "BMP";
            // 
            // P_boxA
            // 
            this.P_boxA.Location = new System.Drawing.Point(6, 334);
            this.P_boxA.Name = "P_boxA";
            this.P_boxA.Size = new System.Drawing.Size(192, 192);
            this.P_boxA.TabIndex = 9;
            this.P_boxA.TabStop = false;
            // 
            // P_boxB
            // 
            this.P_boxB.Location = new System.Drawing.Point(204, 334);
            this.P_boxB.Name = "P_boxB";
            this.P_boxB.Size = new System.Drawing.Size(192, 192);
            this.P_boxB.TabIndex = 10;
            this.P_boxB.TabStop = false;
            // 
            // MySeqListView
            // 
            this.MySeqListView.Font = new System.Drawing.Font("LEMON MILK", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MySeqListView.GridLines = true;
            this.MySeqListView.GroupImageList = this.MyLoadedImages;
            this.MySeqListView.HideSelection = false;
            this.MySeqListView.LargeImageList = this.MyLoadedImages;
            this.MySeqListView.Location = new System.Drawing.Point(340, 74);
            this.MySeqListView.Name = "MySeqListView";
            this.MySeqListView.Size = new System.Drawing.Size(816, 406);
            this.MySeqListView.SmallImageList = this.MyLoadedImages;
            this.MySeqListView.StateImageList = this.MyLoadedImages;
            this.MySeqListView.TabIndex = 12;
            this.MySeqListView.TileSize = new System.Drawing.Size(128, 128);
            this.MySeqListView.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.TAB_VIDEO);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 560);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_s_open);
            this.tabPage2.Controls.Add(this.LBL_Folder);
            this.tabPage2.Controls.Add(this.LBL_DIRECTORY);
            this.tabPage2.Controls.Add(this.MyTreeView);
            this.tabPage2.Controls.Add(this.MySeqListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1171, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simple";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_s_open
            // 
            this.btn_s_open.Image = ((System.Drawing.Image)(resources.GetObject("btn_s_open.Image")));
            this.btn_s_open.Location = new System.Drawing.Point(7, 24);
            this.btn_s_open.Name = "btn_s_open";
            this.btn_s_open.Size = new System.Drawing.Size(59, 40);
            this.btn_s_open.TabIndex = 17;
            this.btn_s_open.UseVisualStyleBackColor = true;
            this.btn_s_open.Click += new System.EventHandler(this.btn_s_open_Click);
            // 
            // LBL_Folder
            // 
            this.LBL_Folder.AutoSize = true;
            this.LBL_Folder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LBL_Folder.Location = new System.Drawing.Point(340, 3);
            this.LBL_Folder.Name = "LBL_Folder";
            this.LBL_Folder.Size = new System.Drawing.Size(53, 21);
            this.LBL_Folder.TabIndex = 16;
            this.LBL_Folder.Text = "label1";
            // 
            // LBL_DIRECTORY
            // 
            this.LBL_DIRECTORY.AutoSize = true;
            this.LBL_DIRECTORY.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LBL_DIRECTORY.Location = new System.Drawing.Point(7, 0);
            this.LBL_DIRECTORY.Name = "LBL_DIRECTORY";
            this.LBL_DIRECTORY.Size = new System.Drawing.Size(53, 21);
            this.LBL_DIRECTORY.TabIndex = 15;
            this.LBL_DIRECTORY.Text = "label1";
            // 
            // MyTreeView
            // 
            this.MyTreeView.ContextMenuStrip = this.contextMenuStrip1;
            this.MyTreeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyTreeView.ImageIndex = 0;
            this.MyTreeView.ImageList = this.IL_FolderIconList;
            this.MyTreeView.ItemHeight = 32;
            this.MyTreeView.Location = new System.Drawing.Point(7, 74);
            this.MyTreeView.Name = "MyTreeView";
            this.MyTreeView.SelectedImageIndex = 1;
            this.MyTreeView.ShowNodeToolTips = true;
            this.MyTreeView.Size = new System.Drawing.Size(312, 406);
            this.MyTreeView.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 26);
            // 
            // openFolderToolStripMenuItem1
            // 
            this.openFolderToolStripMenuItem1.Name = "openFolderToolStripMenuItem1";
            this.openFolderToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.openFolderToolStripMenuItem1.Text = "Open Folder";
            this.openFolderToolStripMenuItem1.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem1_Click);
            // 
            // IL_FolderIconList
            // 
            this.IL_FolderIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.IL_FolderIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_FolderIconList.ImageStream")));
            this.IL_FolderIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_FolderIconList.Images.SetKeyName(0, "Folder_Closed.png");
            this.IL_FolderIconList.Images.SetKeyName(1, "Folder_Open.png");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MySeqData);
            this.tabPage1.Controls.Add(this.P_boxA);
            this.tabPage1.Controls.Add(this.P_boxB);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1171, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Raw Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // STS_Base
            // 
            this.STS_Base.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STS_LABEL_TEXT,
            this.PROG_BAR});
            this.STS_Base.Location = new System.Drawing.Point(0, 668);
            this.STS_Base.Name = "STS_Base";
            this.STS_Base.Size = new System.Drawing.Size(1203, 22);
            this.STS_Base.TabIndex = 15;
            this.STS_Base.Text = "statusStrip1";
            // 
            // STS_LABEL_TEXT
            // 
            this.STS_LABEL_TEXT.Name = "STS_LABEL_TEXT";
            this.STS_LABEL_TEXT.Size = new System.Drawing.Size(93, 17);
            this.STS_LABEL_TEXT.Text = "STS_LABEL_TEXT";
            // 
            // PROG_BAR
            // 
            this.PROG_BAR.Name = "PROG_BAR";
            this.PROG_BAR.Size = new System.Drawing.Size(100, 16);
            // 
            // TAB_VIDEO
            // 
            this.TAB_VIDEO.Controls.Add(this.DG_SEQ_SRC);
            this.TAB_VIDEO.Controls.Add(this.LBL_RichText);
            this.TAB_VIDEO.Controls.Add(this.RTB_MyOutputs);
            this.TAB_VIDEO.Location = new System.Drawing.Point(4, 24);
            this.TAB_VIDEO.Name = "TAB_VIDEO";
            this.TAB_VIDEO.Size = new System.Drawing.Size(1171, 532);
            this.TAB_VIDEO.TabIndex = 2;
            this.TAB_VIDEO.Text = "Video";
            this.TAB_VIDEO.UseVisualStyleBackColor = true;
            // 
            // RTB_MyOutputs
            // 
            this.RTB_MyOutputs.Location = new System.Drawing.Point(13, 39);
            this.RTB_MyOutputs.Name = "RTB_MyOutputs";
            this.RTB_MyOutputs.Size = new System.Drawing.Size(589, 439);
            this.RTB_MyOutputs.TabIndex = 0;
            this.RTB_MyOutputs.Text = "";
            // 
            // LBL_RichText
            // 
            this.LBL_RichText.AutoSize = true;
            this.LBL_RichText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LBL_RichText.Location = new System.Drawing.Point(13, 15);
            this.LBL_RichText.Name = "LBL_RichText";
            this.LBL_RichText.Size = new System.Drawing.Size(155, 21);
            this.LBL_RichText.TabIndex = 17;
            this.LBL_RichText.Text = "Video Frame Output";
            // 
            // DG_SEQ_SRC
            // 
            this.DG_SEQ_SRC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_SEQ_SRC.Location = new System.Drawing.Point(624, 39);
            this.DG_SEQ_SRC.Name = "DG_SEQ_SRC";
            this.DG_SEQ_SRC.ReadOnly = true;
            this.DG_SEQ_SRC.RowTemplate.Height = 25;
            this.DG_SEQ_SRC.Size = new System.Drawing.Size(519, 439);
            this.DG_SEQ_SRC.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 690);
            this.Controls.Add(this.STS_Base);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LBL_Status);
            this.Controls.Add(this.MyMainMenuStrip);
            this.MainMenuStrip = this.MyMainMenuStrip;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.MySeqData)).EndInit();
            this.MyMainMenuStrip.ResumeLayout(false);
            this.MyMainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxB)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.STS_Base.ResumeLayout(false);
            this.STS_Base.PerformLayout();
            this.TAB_VIDEO.ResumeLayout(false);
            this.TAB_VIDEO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_SEQ_SRC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog MyFolderBrowser;
        private System.Windows.Forms.MenuStrip MyMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem1;
        private System.Windows.Forms.ImageList MyLoadedImages;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.DataGridView MySeqData;
        private System.Windows.Forms.PictureBox P_boxA;
        private System.Windows.Forms.PictureBox P_boxB;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListView MySeqListView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView MyTreeView;
        private System.Windows.Forms.ImageList IL_FolderIconList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip STS_Base;
        private System.Windows.Forms.ToolStripStatusLabel STS_LABEL_TEXT;
        private System.Windows.Forms.Label LBL_DIRECTORY;
        private System.Windows.Forms.Label LBL_Folder;
        private System.Windows.Forms.Button btn_s_open;
        private System.Windows.Forms.ToolStripProgressBar PROG_BAR;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IsCHK_PNG;
        private System.Windows.Forms.ToolStripMenuItem IsCHK_JPG;
        private System.Windows.Forms.ToolStripMenuItem IsCHK_GIF;
        private System.Windows.Forms.ToolStripMenuItem IsCHK_BMP;
        private System.Windows.Forms.TabPage TAB_VIDEO;
        private System.Windows.Forms.RichTextBox RTB_MyOutputs;
        private System.Windows.Forms.Label LBL_RichText;
        private System.Windows.Forms.DataGridView DG_SEQ_SRC;
    }
}

