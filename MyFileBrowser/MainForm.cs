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
        public List<int> MyFilesFrameCount= new List<int>();


        public MainForm()
        {
            InitializeComponent();
            MyPath = Directory.GetCurrentDirectory();
        }

        //-------------------------------------------------------
        // :: RETURN INDEX OF FILENAME 
        //----------------------------------------------------
        public int GetFileNameIndex(string FileNameIn, Array MyArray)
        {
            // SEARCH THROUGH LSIT TO GET MATCHING INDEX

            if (MyFilesShort.Count > 0 && bHasFolderBeenPicked)
            {

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
            TempString = Regex.Replace(FilenameIn, "[0-9]", string.Empty);

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
                MyFolderBox.Text = MyPath;
                // :: TEMP  -  Filenames into a csv list ?

                big_list_box.Text = GetFolderFilesIntoString(MyPath);

                MyFilesRAW = new List<string>(big_list_box.Text.Split(','));
                
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

                // If first in Sequence 
                if (i == 0) 
                {
                    MyFilesShort.Add(CurrentName);
                }
                // :: If name different to last row.  ::
                
                if (i > 0)
                {
                    if (CurrentName != LastName)
                    {
                        MyFilesShort.Add(CurrentName);
                        j += 1;
                        MyFilesFrameCount.Add(k); // FRAME COUNT??  
                        k = 1;
                    }
                    
                }
                k = k + 1;
                // :: Store Current to 'last' for compare next iteration ::
                LastName = FileNameCleaned(MyFilesRAW[i]);

            }

            for (var i = 0; i < MyFilesShort.Count; i++)
            {
                DebugOutBox.AppendText(MyFilesShort[i] + " Was "+ MyFilesFrameCount[i] + " frames??");
            }
            MyFolderSequenceCount = j;
            MessageBox.Show("J is " + j.ToString(), "aaa");

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
        }


    }

}
