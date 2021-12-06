using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyFileBrowser
{

    // TOdO

    //  get all files into csv/list 
    // add unique 'cleaned' into array 
    //

    public partial class MainForm : Form
    {

        // USED FIELDS ::

        // FOLDER :
        public string MyPath;
        public FileInfo[] MyPickedFiles;  // 
        public bool bHasFolderBeenPicked = false;
        public int MyFolderFileCount = 0;
        public int MyFolderSequenceCount = 0;
        public List<string> MyFilesRAW = new List<string>();
        public List<string> MyFilesShort = new List<string>();
        // Store filename reference for first / last image in sequence.
        public List<string> MyFilesShortImageStart = new List<string>();
        public List<string> MyFilesShortImageEnd = new List<string>();
        public List<int> MyFilesFrameCount= new List<int>();


        public MainForm()
        {
            InitializeComponent();
            MyPath = Directory.GetCurrentDirectory();
            this.Text = "Image Sequence Tool v 0.1.0";
        }

        //-------------------------------------------------------
        // :: RETURN INDEX OF FILENAME 
        //----------------------------------------------------
        public int GetFileNameIndex(string FileNameIn, Array MyArray)
        {
            // SEARCH THROUGH LSIT TO GET MATCHING INDEX

            if (MyFilesShort.Count > 0 && bHasFolderBeenPicked)
            {
                return 0;
            }
            else
            {
                
                return -1; //ERRPR
            }

                
        }

        //-------------------------------------------------------
        // :: GET JUST TEXT PORTION, MASK NUMBER AS XXXX
        //-------------------------------------------------------

        public String FileNameCleaned(string FilenameIn)
        {
            string TempString;
            TempString = Regex.Replace(FilenameIn, "[0-9]", "_"); // string.Empty);

            return TempString;
        }
        //----------------------------------------------------
        // GET JUST NUMBER PORTION OF FILENAME ::
        //-----------------------------------------------------
        public Int32 FileNameNumeric(string FilenameIn)
        {
            string TempString;
            int TempNum = 1;
            int TempNumB;
            TempString = Regex.Match(FilenameIn, @"\d+").Value;
            if (int.TryParse(TempString, out TempNumB))
            {
                TempNum = TempNumB;
            }

            return TempNum;
        }
        private void btn_load_Click(object sender, EventArgs e)
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
                string MyPath = MyFolderBrowser.SelectedPath;
                string MyDataCSV;
                MyFolderBox.Text = MyPath;
                // :: TEMP  -  Filenames into a csv list ?

                MyDataCSV= GetFolderFilesIntoString(MyPath);

                MyFilesRAW = new List<string>(MyDataCSV.Split(','));
                
                //-----------------------------------------
                // :: Do list of image sequences found.. ::
                //------------------------------------------
                
                DoCompressedList();

                // :: Output / debug test... 

                groupBox1.Text = "Folder " + MyPath + " searched @ " + DateTime.Now.ToString() + " found  " + MyFolderFileCount.ToString() + " items.";
                
                bHasFolderBeenPicked = true;
            }
        }


        //-------------------------------------------------------------------------------
        //--- 
        //---   :: GET INTO COMMA SEPARATED LIST .. .
        //--- 
        //-------------------------------------------------------------------------------
        public string GetFolderFilesIntoString(string MyFolder)
        {
            DirectoryInfo d = new(MyFolder); //Assuming Test is your Folder
            MyPickedFiles = d.GetFiles("*.png"); //Getting Text files

            MyFolderFileCount = MyPickedFiles.Length;

            string str = "";

            foreach (FileInfo file in MyPickedFiles)
            {
                if (str.Length > 0)
                {
                    str = str + ", " + Environment.NewLine + file.Name;
                }
                else
                {
                    str = file.Name;
                }

            }

            return str;
        }

        public void DoCompressedList()
        {
            string LastName="";
            string CurrentName ;
            int k = 1; // ::: Count of potential frames in sequence - always start with 1 :::
            int j = 0; // ::: Iterator for Sequence block count :::
            for (var i = 0; i < MyFilesRAW.Count-1; i++)
            {
                CurrentName = FileNameCleaned(MyFilesRAW[i]);

                if (CurrentName != LastName && i>0)
                {
                    MyFilesShort.Add(CurrentName);
                    MyFilesShortImageStart.Add(MyFilesRAW[i]);
                    MyFilesShortImageEnd.Add(MyFilesRAW[i]);
                    MyFilesFrameCount.Add(1);


                  
                    if (j > 0) 
                    {
                        MyFilesShortImageStart.Add(MyFilesRAW[i]);
                        MyFilesShortImageEnd[j - 1] = MyFilesRAW[i-1];
                        MyFilesFrameCount[j - 1] = k;               //  :: Complete frame count for previous entry 
                        

                    }; 


                    j += 1;
                    k = 1;

                }

                // Add for the last file in list..
                if (i == MyFilesRAW.Count - 1)
                {
                    MyFilesShortImageEnd[j] = MyFilesRAW[i];
                }

                k += 1;
                // :: Store Current to 'last' for compare next iteration ::
                LastName = FileNameCleaned(MyFilesRAW[i]);


            }

            /*
            // write out to debug window.
            for (var i = 0; i < MyFilesShort.Count-1; i++)
            {
                DebugOutBox.AppendText(MyFilesShort[i] + " has "+ MyFilesFrameCount[i] + " frames using " + MyFilesShortImageStart[i]);
            }
            */
            MyFolderSequenceCount = j;
            

            
            //MessageBox.Show("J is " + j.ToString(), "aaa");

        }

        // :: ABOOOT :::
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            using (AboutBox1 box = aboutBox1)
            {
                box.ShowDialog(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// DO Nothing for now.
            /// 
            
            for (var i = 0; i < MyFolderSequenceCount -1 ; i++)
            {

                string[] NewListItemRow = new string[4];
                ListViewItem NewListItem;

                //add items to ListView
                NewListItemRow[0] = MyFilesShort[i];
                NewListItemRow[1] = MyFilesFrameCount[i].ToString();
                NewListItemRow[2] = MyFilesShortImageStart[i];
                NewListItemRow[3] = MyFilesShortImageEnd[i];

                NewListItem = new ListViewItem(NewListItemRow);
                DataListView.Items.Add(NewListItem);

            }
            

        }

        private void DataListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }

}
