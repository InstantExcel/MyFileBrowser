
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
            this.DebugOutBox = new System.Windows.Forms.TextBox();
            this.DataListView = new System.Windows.Forms.ListView();
            this.Seq_Name = new System.Windows.Forms.ColumnHeader();
            this.Seq_FrameCount = new System.Windows.Forms.ColumnHeader();
            this.Seq_StartNum = new System.Windows.Forms.ColumnHeader();
            this.Seq_EndNum = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MyFolderBox = new System.Windows.Forms.TextBox();
            this.big_list_box = new System.Windows.Forms.TextBox();
            this.MyFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Image = ((System.Drawing.Image)(resources.GetObject("btn_load.Image")));
            this.btn_load.Location = new System.Drawing.Point(597, 427);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(106, 41);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Pick Folder";
            this.btn_load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.DebugOutBox);
            this.groupBox1.Controls.Add(this.DataListView);
            this.groupBox1.Controls.Add(this.MyFolderBox);
            this.groupBox1.Controls.Add(this.big_list_box);
            this.groupBox1.Controls.Add(this.btn_load);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 599);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Image Sequences";
            // 
            // DebugOutBox
            // 
            this.DebugOutBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DebugOutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebugOutBox.Location = new System.Drawing.Point(182, 509);
            this.DebugOutBox.Multiline = true;
            this.DebugOutBox.Name = "DebugOutBox";
            this.DebugOutBox.Size = new System.Drawing.Size(149, 65);
            this.DebugOutBox.TabIndex = 5;
            // 
            // DataListView
            // 
            this.DataListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.DataListView.BackgroundImageTiled = true;
            this.DataListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Seq_Name,
            this.Seq_FrameCount,
            this.Seq_StartNum,
            this.Seq_EndNum});
            this.DataListView.GroupImageList = this.imageList1;
            this.DataListView.HideSelection = false;
            this.DataListView.Location = new System.Drawing.Point(20, 22);
            this.DataListView.MultiSelect = false;
            this.DataListView.Name = "DataListView";
            this.DataListView.Size = new System.Drawing.Size(1117, 358);
            this.DataListView.TabIndex = 4;
            this.DataListView.UseCompatibleStateImageBehavior = false;
            this.DataListView.View = System.Windows.Forms.View.Details;
            this.DataListView.SelectedIndexChanged += new System.EventHandler(this.DataListView_SelectedIndexChanged);
            // 
            // Seq_Name
            // 
            this.Seq_Name.Text = "Sequence Name";
            this.Seq_Name.Width = 300;
            // 
            // Seq_FrameCount
            // 
            this.Seq_FrameCount.Text = "Frames";
            this.Seq_FrameCount.Width = 100;
            // 
            // Seq_StartNum
            // 
            this.Seq_StartNum.Text = "Start Frame";
            this.Seq_StartNum.Width = 100;
            // 
            // Seq_EndNum
            // 
            this.Seq_EndNum.Text = "End Frame";
            this.Seq_EndNum.Width = 100;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "btn_image.png");
            // 
            // MyFolderBox
            // 
            this.MyFolderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MyFolderBox.Location = new System.Drawing.Point(20, 437);
            this.MyFolderBox.Name = "MyFolderBox";
            this.MyFolderBox.Size = new System.Drawing.Size(561, 23);
            this.MyFolderBox.TabIndex = 2;
            // 
            // big_list_box
            // 
            this.big_list_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.big_list_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.big_list_box.Location = new System.Drawing.Point(20, 513);
            this.big_list_box.Multiline = true;
            this.big_list_box.Name = "big_list_box";
            this.big_list_box.Size = new System.Drawing.Size(146, 61);
            this.big_list_box.TabIndex = 1;
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
            this.AboutToolStripMenuItem1});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.AboutToolStripMenuItem.Text = "Image Sequence Thing V1";
            // 
            // AboutToolStripMenuItem1
            // 
            this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
            this.AboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem1.Text = "About";
            this.AboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1140, 22);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 358);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MyFolderBox;
        private System.Windows.Forms.TextBox big_list_box;
        private System.Windows.Forms.FolderBrowserDialog MyFolderBrowser;
        private System.Windows.Forms.ListView DataListView;
        private System.Windows.Forms.ColumnHeader Seq_Name;
        private System.Windows.Forms.ColumnHeader Seq_FrameCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox DebugOutBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Seq_StartNum;
        private System.Windows.Forms.ColumnHeader Seq_EndNum;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

