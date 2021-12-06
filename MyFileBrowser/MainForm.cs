using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;

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


        // ------ [  3   ] ----------------
        // SEQUENCE RAW 
        // SEQ_PATH,SEQ_NAME,INDEX,TYPE,OWN_FRAME_NUMBER



        // CLEAN FILENAME 



        // :: FOLDER // FILE INFO ::
        public string MyPath;
        public string[] MyFileTypesStr = new string[8];
        public FileInfo[] MyPickedFiles;  // 

        public int MyFolderFileCount = 0;
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
            MyFolderBox.Text = MyPath;
            GetVisibleFiletypes();
            TBL_FileInfo_Init(); // Initialise main table ::
            this.Text = "Image Sequence Tool v 0.1.0";
            LST_Formats.SetItemChecked(2,true);           // PNG AS DEFAULT

         

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
                MyFolderBox.Text = MyPath;
                
                DataRow dRow;
                
                //var allowedExtensions = new[] { ".doc", ".docx", ".pdf", ".ppt", ".pptx", ".xls", ".xslx" };
                //var allowedExtensions = new[] { ".png", ".jpg", ".bmp" };
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

                LBL_Status.Text = "Folder " + MyPath + " searched @ " + DateTime.Now.ToString() + " found  " + MyFolderFileCount.ToString() + " items.";

                bHasFolderBeenPicked = true;


            }
        }
        
        private void GetVisibleFiletypes()
        {

            int i;
            int j = 0;
            string s;
            s = "Checked items:\n";
            MyFileTypesStr=new string[LST_Formats.SelectedItems.Count];
            
            for (i = 0; i <= (LST_Formats.Items.Count - 1); i++)
            {

                if (LST_Formats.GetItemChecked(i))

                {
                    MyFileTypesStr[j] = LST_Formats.Items[i].ToString();
                    j += 1;
                    s = s + "Item " + (i + 1).ToString() + " = " + LST_Formats.Items[i].ToString() + "\n";
                }
            }
            
            LBL_Status.Text = string.Join(",", MyFileTypesStr); 
        }


        // ::::::::::::::::::::::::::::::::::
        // :: ABOUT WINDOW                :::
        // ::::::::::::::::::::::::::::::::::
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            using AboutBox1 aboutBox1 = new();
            aboutBox1.ShowDialog(this);
        }



  
        private void LST_Formats_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVisibleFiletypes();
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

            MyDataGrid.DataSource = MyFileTable;

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
                DataView TempView = new DataView(MyFileTable);
                DataTable distinctValues = TempView.ToTable(true, "Path", "Sequence");


                //temp out::
                //MySeqData.DataSource = distinctValues;

                // ITERATE OVER UNIQUE 
                for (int i = 0; i < distinctValues.Rows.Count ; i++)
                {
                    string MySeqSearch = distinctValues.Rows[i]["Sequence"].ToString();
                    var ids = MyFileTable.AsEnumerable().Where(r => r.Field<string>("Sequence") == MySeqSearch).Select(r => r.Field<String>("Name")).ToList();
                    MessageBox.Show("My List has " + ids.Count.ToString()  + "From " + ids.First()+ " To "+ ids.Last() );
                    /*
                    string MySearchExp = "Sequence = "+ distinctValues.Rows[i]["Sequence"];
                    DataRow[] foundRows;
                    foundRows = MyFileTable.Select(MySearchExp);
                    List<String> stringArr = new List<String>();
                    */

                    dRow = MySequences.NewRow();
                    dRow["SEQ_PATH"] = distinctValues.Rows[i]["Path"];
                    dRow["SEQ_NAME"] =  distinctValues.Rows[i]["Sequence"];
                    dRow["SEQ_FRAMES"] = MyFileTable.Select("Sequence = '"+distinctValues.Rows[i]["Sequence"]+"'").Length;
                    dRow["SEQ_START_IDX"] = ids.First();
                    dRow["SEQ_END_IDX"] = ids.Last();
                    MySequences.Rows.Add(dRow);
                }
            }

            MySeqData.DataSource = MySequences;

           
            //grid.DataContext = table.DefaultView;

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            TBL_SeqInfo_Init();
        }

        private void MySeqData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageCell cell = (DataGridViewImageCell)
            MySeqData.Rows[e.RowIndex].Cells[e.ColumnIndex];
            MessageBox.Show("Clicked Cell  " + cell.Value.ToString()+ " @ X:"+ e.ColumnIndex.ToString()+ " Y:"+ e.RowIndex.ToString());
            
        }
    }

}
