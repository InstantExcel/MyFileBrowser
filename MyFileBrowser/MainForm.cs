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
        public string[] MyFileTypesStr = new string[8];
        public FileInfo[] MyPickedFiles;  // 

        public int MyFolderFileCount = 0;
        public int MySequenceCount = 0;
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
            MyPath = Directory.GetCurrentDirectory();
            // ::Set Initial Path ::
            TBL_FileInfo_Init(); // Initialise main table ::
            this.Text = "Image Sequence Tool v 0.1.0";
         

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
        private void Btn_load_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        //--------------------------------------------------------------
        // ::  Pick folder, store data into lists :::::::::::::::::::::
        //--------------------------------------------------------------
        public void ChooseFolder()
        {
            if (MyFolderBrowser.ShowDialog() == DialogResult.OK)
            {

                TBL_FileInfo_Init(); // initialise table again;
                MyPath = MyFolderBrowser.SelectedPath;
                
                DataRow dRow;
             
                DirectoryInfo d = new(MyPath); //Assuming Test is your Folder
                MyPickedFiles = d.GetFiles();
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

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

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

                    Image TmpWhole= Image.FromFile(TmpFullPath);
                    Image TmpImageThumb= TmpWhole.GetThumbnailImage(64, (64 * TmpWhole.Height) / TmpWhole.Width, null, IntPtr.Zero);
                    MyLoadedImages.Images.Add(Tmp_Name, TmpImageThumb);
                }
            }
            
            MySeqData.DataSource = MySequences;
            
            MySequenceCount = MySequences.Rows.Count;

            //grid.DataContext = table.DefaultView;

        }
 

        private void DoLoadPictureBoxes()
        {
            String MyStartImage;
            String MyEndImage;
            String MyPath;
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
            P_boxA.Image = IMG_Start.GetThumbnailImage(64, (64 * IMG_Start.Height) / IMG_Start.Width, null, IntPtr.Zero);
            P_boxB.Image = IMG_End.GetThumbnailImage(64, (64 * IMG_End.Height) / IMG_End.Width, null, IntPtr.Zero);


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

        private  void UpdateStats()
        {
            LBL_Status.Text = "Folder " + MyPath + " searched @ " + DateTime.Now.ToString() + Environment.NewLine;
            LBL_Status.Text += "File Count" + MyFolderFileCount.ToString()+ Environment.NewLine;
            LBL_Status.Text += "Sequence Count" + MySequenceCount.ToString() + Environment.NewLine;
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


    }

}
