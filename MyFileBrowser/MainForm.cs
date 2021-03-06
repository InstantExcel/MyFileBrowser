using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Drawing;
using FFMediaToolkit;
using System.Drawing.Drawing2D;
using FFMediaToolkit.Encoding;

namespace MyFileBrowser
{

    public partial class MainForm : Form
    {

        // USED FIELDS ::

        // ------ [  1   ] ----------------
        // FILEDATA
        // PATH, NAME, SEQ_NAME, MODIFIED ,TYPE

        DataTable MyFileTable;//= new DataTable();
        DirectoryInfo directoryInfo;
        

    // ------ [  2   ] ----------------
    // SEQUENCE SET INFO :
    // SEQ_PATH,SEQ_NAME, FRAME COUNT , START INDEX, END INDEX ,


        DataTable MySequences;// = new DataTable();

        public int MySelectedSequenceID = 0;

        // ------ [  3   ] ----------------
        // SEQUENCE RAW 
        // SEQ_PATH,SEQ_NAME,INDEX,TYPE,OWN_FRAME_NUMBER



        // CLEAN FILENAME 



        // :: FOLDER // FILE INFO ::
        public string MyPath;
        public string MyPickedFolder;
        public string[] MyFileTypesStr = new string[8];
        public FileInfo[] MyPickedFiles;  // 

        public int MyFolderFileCount = 0;
        public int MySequenceCount = 0;
        public int MyImageThumbCount = 0;
        public bool bHasFolderBeenPicked = false;


        /*
        
        public int MyFolderSequenceCount = 0;
        public List<string> MyFilesRAW = new List<string>();
        public List<string> MyFilesShort = new List<string>();
        // Store filename reference for first / last image in sequence.
        public List<string> MyFilesShortImageStart = new List<string>();
        public List<string> MyFilesShortImageEnd = new List<string>();
        public List<int> MyFilesFrameCount= new List<int>();

        */
        public MainForm()
        {
            InitializeComponent();
            MyPath = @"C:\tmp"; //Directory.GetCurrentDirectory();
            // ::Set Initial Path ::
            TBL_FileInfo_Init(); // Initialise main table ::
            this.Text = "Image Sequence Tool v 0.1.0";

            directoryInfo = new DirectoryInfo(@"C:\tmp");
            if (directoryInfo.Exists)
            {
                MyTreeView.AfterSelect += MyTreeView_AfterSelect;
                BuildTree(directoryInfo, MyTreeView.Nodes);
            }

            UpdateStats();

        }


        //-*-
        //:   TREEEEEEEEEEEEEEE
        // ----

        private void ReloadTreeFromPath ()
        {
            MyTreeView.Nodes.Clear();
            directoryInfo = new DirectoryInfo(MyPath);
            if (directoryInfo.Exists)
            {
                MyTreeView.AfterSelect += MyTreeView_AfterSelect;
                BuildTree(directoryInfo, MyTreeView.Nodes);
            }

        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

        

            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                if (directoryInfo.Attributes.HasFlag(FileAttributes.Hidden)) continue;

                BuildTree(subdir, curNode.Nodes);
            }
        }

        private void MyTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //
            /// MessageBox.Show("hheeeellooooo" + e.Node.Name + e.Node.Text);
            //Directory.GetDirectories(Directory.GetDirectories(e.Node.Text))
            //e.Node.Parent.Text;

            TreeNode CurrentNode = e.Node;
            string fullpath = GetKeyPath( CurrentNode);
            
            fullpath = ((TreeView)sender).SelectedNode.FullPath;
            fullpath = String.Join(@"\", fullpath.Split('\\').Skip(1));
            fullpath = MyPath +"\\" + fullpath;
            MyPickedFolder = fullpath;
            STS_LABEL_TEXT.Text = MyPickedFolder;
            UpdateStats();

            LoadFolder(MyPickedFolder);

            //MessageBox.Show(fullpath);

        }

        public virtual void PickRootPath()
        {
            if (MyFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                MyPath = MyFolderBrowser.SelectedPath;
            }

            ReloadTreeFromPath();

        }

        public string GetKeyPath(TreeNode node)
        {
            if (node.Parent == null)
            {
                return MyPath;
            }

            return GetKeyPath(node.Parent) + "//" + node.Name;
        }

        //-------------------------------------------------------
        // :: GET JUST TEXT PORTION, MASK NUMBER AS XXXX
        //-------------------------------------------------------

        public static String FileNameCleaned(string FilenameIn)
        {
            string TempString;
            FilenameIn=Path.GetFileNameWithoutExtension(FilenameIn);
            TempString = Regex.Replace(FilenameIn, "[0-9]", "_"); // string.Empty);

            int freq = TempString.Count(f => (f == '_'));
            if (freq == TempString.Length)
            {
                TempString ="NoName";
            }
            TempString = TempString.Replace("_",String.Empty);
            return TempString;

        }
        //----------------------------------------------------
        // GET JUST NUMBER PORTION OF FILENAME ::
        //-----------------------------------------------------
        public static Int32 FileNameNumeric(string FilenameIn, out int TempNumB)
        {
            string TempString;
            int TempNum = 1;
            
            TempString = Regex.Match(FilenameIn, @"\d+").Value;
            if (int.TryParse(TempString, out TempNumB))
            {
                TempNum = TempNumB;
            }

            return TempNum;
        }

        //--------------------------------------------------------------
        // ::  Pick folder, store data into lists :::::::::::::::::::::
        //--------------------------------------------------------------
        public void LoadFolder(string MyFolderPathInput)
        {
            TBL_FileInfo_Init(); // initialise table again;


            // If input supplied
            if (MyFolderPathInput.Length > 0)
            {

                DataRow dRow;

                DirectoryInfo d = new(MyFolderPathInput); //Assuming Test is your Folder
                MyPickedFiles = d.GetFiles("*.png");// System.IO.Directory.GetFiles(MyFolderPathInput, "*.png");
                MyFolderFileCount = MyPickedFiles.Length;

                    foreach (FileInfo item in MyPickedFiles)
                    {
                        dRow = MyFileTable.NewRow();
                        dRow["Path"] = item.Directory.FullName;
                        dRow["Name"] = item.Name;
                        dRow["Sequence"] = FileNameCleaned(item.Name);
                        dRow["Modified"] = item.LastWriteTime;
                        dRow["Type"] = item.Extension;
                        MyFileTable.Rows.Add(dRow);

                    }



                // :: Output / debug test... 



                bHasFolderBeenPicked = true;

                // :: Create Table of Sequence Info
                TBL_SeqInfo_Init();
                /// Update Stats
                UpdateStats();
            }
            
        }
        


        // ::::::::::::::::::::::::::::::::::
        // :: ABOUT WINDOW                :::
        // ::::::::::::::::::::::::::::::::::
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            using AboutBox1 aboutBox1 = new();
            aboutBox1.ShowDialog(this);
        }
        // ::::::::::::::::::::::::::::::::::
        // :: FOLDER DIALOGUE             :::
        // ::::::::::::::::::::::::::::::::::


        // ::  MENU BAR :::
        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PickRootPath();
        }

        private void btn_s_open_Click(object sender, EventArgs e)
        {
            PickRootPath();
        }

        // :: CONTEXT MENU ON TREE :::
   
        private void TBL_FileInfo_Init()
        {
            // PATH, NAME, SEQ_NAME, MODIFIED ,TYPE

            MyFileTable = new DataTable();
            MyFileTable.Columns.Add("Path");
            MyFileTable.Columns.Add("Name");
            MyFileTable.Columns.Add("Sequence");
            MyFileTable.Columns.Add("Modified");
            MyFileTable.Columns.Add("Type");

            // MyDataGrid.DataSource = MyFileTable;
            //grid.DataContext = table.DefaultView;

        }

        private void TBL_SeqInfo_Init()
        {
            // SEQ_PATH,SEQ_NAME, FRAME COUNT , START INDEX, END INDEX ,
            DataRow dRow;

            MySequences = new DataTable();
            MySequences.Columns.Add("SEQ_PATH",typeof(String));
            MySequences.Columns.Add("SEQ_NAME");
            MySequences.Columns.Add("SEQ_FRAMES",typeof(Int32));
            MySequences.Columns.Add("SEQ_START_IDX");
            MySequences.Columns.Add("SEQ_END_IDX");

            MySeqData.DataSource = MySequences;

            if (MyFileTable.Rows.Count > 0)
            {
                DataView TempView = new(table: MyFileTable);
                DataTable distinctValues = TempView.ToTable(true, "Path", "Sequence");
                // CLEAR DOWN LISTVIEW
                MySeqListView.Items.Clear();
                MyLoadedImages.Dispose();
                //MyLoadedImages = new ImageList(); // MAKE NEW
                MyLoadedImages.ImageSize = new Size(64, 64); 
                //-------------------------------------------------------------
                // :: Add prototype columns ::
                //-------------------------------------------------------------

                //MySeqListView.Columns.Add("Sequence_Image");
                MySeqListView.Columns.Add("Sequence_Name");
                //MySeqListView.Columns.Add("Sequence_Frame_Count");
                //MySeqListView.Columns.Add("Sequence_Index");

                //temp out::
                //MySeqData.DataSource = distinctValues;

                // ITERATE OVER UNIQUE 
                for (int i = 0; i < distinctValues.Rows.Count ; i++)
                {
                    
                    string MySeqSearch = distinctValues.Rows[i]["Sequence"].ToString();
                    var ids = MyFileTable.AsEnumerable().Where(r => r.Field<string>("Sequence") == MySeqSearch).Select(r => r.Field<String>("Name")).ToList();
                    
                    string Tmp_Path = distinctValues.Rows[i]["Path"].ToString();
                    string Tmp_Name = distinctValues.Rows[i]["Sequence"].ToString();
                    int TmpFrameCount = MyFileTable.Select("Sequence = '" + distinctValues.Rows[i]["Sequence"] + "'").Length;
                    string Tmp_SeqStartImgPath = ids.First();
                    string Tmp_SeqEndImgPath = ids.Last();
                    string TmpFullPath = Tmp_Path + "/" + Tmp_SeqStartImgPath;
                    string TmpGridItem = Tmp_Name + "( " + TmpFrameCount.ToString() + " )";
                    dRow = MySequences.NewRow();
                    dRow["SEQ_PATH"] = Tmp_Path;//distinctValues.Rows[i]["Path"];
                    dRow["SEQ_NAME"] = Tmp_Name;// distinctValues.Rows[i]["Sequence"];
                    dRow["SEQ_FRAMES"] = TmpFrameCount;// MyFileTable.Select("Sequence = '"+distinctValues.Rows[i]["Sequence"]+"'").Length;
                    dRow["SEQ_START_IDX"] = Tmp_SeqStartImgPath;// ids.First();
                    dRow["SEQ_END_IDX"] = Tmp_SeqEndImgPath;// ids.Last();
                    MySequences.Rows.Add(dRow);

                    ListViewItem TmpItem= new ListViewItem();
                    TmpItem.ImageIndex = i;
                    TmpItem.Text = TmpGridItem;
                    MySeqListView.Items.Add(TmpItem);

                }
                MyImageThumbCount = MyLoadedImages.Images.Count;
            }
            RefreshImageList();
            MySeqData.DataSource = MySequences;
            
            MySequenceCount = MySequences.Rows.Count;

            //grid.DataContext = table.DefaultView;

        }
 
        private void RefreshImageList()
        {
            MyLoadedImages = new ImageList();
            int MyImgSz = 256;
            //View.LargeIcon;
            if (MyLoadedImages.Images.Count > 0)
            {
                MyLoadedImages.Dispose();
                MyLoadedImages.Images.Clear();
            }
            
            

            if (MySequences.Rows.Count > 0)
            {
                for (int i = 0; i < MySequences.Rows.Count; i++)
                {
                    string Tmp_Name = MySequences.Rows[i]["SEQ_NAME"].ToString();
                    string Tmp_Path = MySequences.Rows[i]["SEQ_PATH"].ToString();
                    string TmpFullPath = Tmp_Path + "/" + MySequences.Rows[i]["SEQ_START_IDX"].ToString();
                    Image TmpWhole = Image.FromFile(TmpFullPath);
                    Bitmap TmpImageThumb = new Bitmap(TmpWhole.GetThumbnailImage(MyImgSz * TmpWhole.Width, (MyImgSz * TmpWhole.Height) / TmpWhole.Width, null, IntPtr.Zero));
                    MyLoadedImages.Images.Add(Tmp_Name, TmpImageThumb);
                }

            }
            MyImageThumbCount = MyLoadedImages.Images.Count;

            UpdateStats();
            MyLoadedImages.ImageSize = new Size(MyImgSz, MyImgSz);
            MySeqListView.LargeImageList = MyLoadedImages;
            MySeqListView.View= View.LargeIcon;
            MySeqListView.Refresh();
        }

        private void DoLoadPictureBoxes()
        {
            String MyStartImage;
            String MyEndImage;
            String MyPath;
            int MyImageSize = 256;
            if (MySequences.Rows.Count -1 >= MySelectedSequenceID) {
                MyPath = MySequences.Rows[MySelectedSequenceID]["SEQ_PATH"].ToString();
                MyStartImage = MyPath+"/" + MySequences.Rows[MySelectedSequenceID]["SEQ_START_IDX"].ToString();
                MyEndImage = MyPath + "/" + MySequences.Rows[MySelectedSequenceID]["SEQ_END_IDX"].ToString();

                Image IMG_Start;
                Image IMG_End;
                FileStream fs;
                fs = new System.IO.FileStream(MyStartImage, FileMode.Open, FileAccess.Read);
                IMG_Start = Image.FromStream(fs);
                fs.Close();
                fs = new System.IO.FileStream(MyEndImage, FileMode.Open, FileAccess.Read);
                IMG_End = Image.FromStream(fs);
                fs.Close();
                P_boxA.Image = IMG_Start.GetThumbnailImage(MyImageSize, (MyImageSize * IMG_Start.Height) / IMG_Start.Width, null, IntPtr.Zero);
                P_boxB.Image = IMG_End.GetThumbnailImage(MyImageSize, (MyImageSize * IMG_End.Height) / IMG_End.Width, null, IntPtr.Zero);
                
            }
        }
        private void BTN_refresh_Click(object sender, EventArgs e)
        {
            TBL_SeqInfo_Init();
        }

        private void MySeqData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell= (DataGridViewTextBoxCell)
            MySeqData.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //MessageBox.Show("Clicked Cell  " + cell.Value.ToString()+ " @ X:"+ e.ColumnIndex.ToString()+ " Y:"+ e.RowIndex.ToString());
            MySelectedSequenceID = e.RowIndex;// Set Index ...
            DoLoadPictureBoxes();
        }

        private void MySeqData_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            
            //MessageBox.Show("Clicked Cell  " + cell.Value.ToString()+ " @ X:"+ e.ColumnIndex.ToString()+ " Y:"+ e.RowIndex.ToString());
            MySelectedSequenceID = e.Row.Index;// Set Index ...
            DoLoadPictureBoxes();
        }
        private  void UpdateStats()
        {
            LBL_Status.Text = "Folder " + MyPath + " searched @ " + DateTime.Now.ToString() + Environment.NewLine;
            LBL_Status.Text += "File Count" + MyFolderFileCount.ToString()+ Environment.NewLine;
            LBL_Status.Text += "Sequence Count" + MySequenceCount.ToString() + Environment.NewLine;
            LBL_Status.Text += "Image Thumb Count " + MyImageThumbCount.ToString();
            LBL_DIRECTORY.Text = "Directory : " + MyPath;
            LBL_Folder.Text = "Items : " + MyPickedFolder;
            //ch  " found  " + MyFolderFileCount.ToString() + " items.";
        }

        //---------------------------------------------------------------------------------------------------------------

        private static void DoTempVideoOut()
        {

            // You can set there codec, bitrate, frame rate and many other options.
            var settings = new VideoEncoderSettings(width: 1920, height: 1080, framerate: 30, codec: VideoCodec.H264);
            settings.EncoderPreset = EncoderPreset.Fast;
            settings.CRF = 17;
            using (var file = MediaBuilder.CreateContainer(@"C:\videos\example.mp4").WithVideo(settings).Create())
            {
                /*
                while (file.Video. < 300)
                {
                    file.Video.AddFrame(
                
                );
                }
            */
            }
        }

        private void gFIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
