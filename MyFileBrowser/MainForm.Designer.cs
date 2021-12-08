
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
            this.P_boxA = new System.Windows.Forms.PictureBox();
            this.P_boxB = new System.Windows.Forms.PictureBox();
            this.MySeqListView = new System.Windows.Forms.ListView();
            this.PB_TEST_LIST = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MySeqData)).BeginInit();
            this.MyMainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TEST_LIST)).BeginInit();
            this.SuspendLayout();
            // 
            // MySeqData
            // 
            this.MySeqData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MySeqData.Location = new System.Drawing.Point(12, 95);
            this.MySeqData.Name = "MySeqData";
            this.MySeqData.ReadOnly = true;
            this.MySeqData.RowTemplate.Height = 25;
            this.MySeqData.Size = new System.Drawing.Size(465, 361);
            this.MySeqData.TabIndex = 8;
            this.MySeqData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MySeqData_CellClick);
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
            this.LBL_Status.Location = new System.Drawing.Point(728, 485);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(39, 15);
            this.LBL_Status.TabIndex = 7;
            this.LBL_Status.Text = "Status";
            // 
            // MyMainMenuStrip
            // 
            this.MyMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
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
            // P_boxA
            // 
            this.P_boxA.Location = new System.Drawing.Point(12, 475);
            this.P_boxA.Name = "P_boxA";
            this.P_boxA.Size = new System.Drawing.Size(192, 192);
            this.P_boxA.TabIndex = 9;
            this.P_boxA.TabStop = false;
            // 
            // P_boxB
            // 
            this.P_boxB.Location = new System.Drawing.Point(257, 475);
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
            this.MySeqListView.Location = new System.Drawing.Point(499, 95);
            this.MySeqListView.Name = "MySeqListView";
            this.MySeqListView.Size = new System.Drawing.Size(678, 361);
            this.MySeqListView.SmallImageList = this.MyLoadedImages;
            this.MySeqListView.StateImageList = this.MyLoadedImages;
            this.MySeqListView.TabIndex = 12;
            this.MySeqListView.TileSize = new System.Drawing.Size(128, 128);
            this.MySeqListView.UseCompatibleStateImageBehavior = false;
            // 
            // PB_TEST_LIST
            // 
            this.PB_TEST_LIST.Location = new System.Drawing.Point(499, 475);
            this.PB_TEST_LIST.Name = "PB_TEST_LIST";
            this.PB_TEST_LIST.Size = new System.Drawing.Size(64, 64);
            this.PB_TEST_LIST.TabIndex = 13;
            this.PB_TEST_LIST.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 660);
            this.Controls.Add(this.PB_TEST_LIST);
            this.Controls.Add(this.MySeqListView);
            this.Controls.Add(this.MySeqData);
            this.Controls.Add(this.P_boxB);
            this.Controls.Add(this.P_boxA);
            this.Controls.Add(this.LBL_Status);
            this.Controls.Add(this.MyMainMenuStrip);
            this.MainMenuStrip = this.MyMainMenuStrip;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.MySeqData)).EndInit();
            this.MyMainMenuStrip.ResumeLayout(false);
            this.MyMainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_boxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TEST_LIST)).EndInit();
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
        private System.Windows.Forms.PictureBox PB_TEST_LIST;
    }
}

