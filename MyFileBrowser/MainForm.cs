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
        public List<string> MyFilesRAW;
        public List<string> MyFilesShort;


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

            return -1;
        }

        //-------------------------------------------------------
        // :: GET JUST TEXT PORTION, MASK NUMBER AS XXXX
        //----------------------------------------------------

        public String FileNameCleaned(string FilenameIn)
        {
            string TempString;

            // Nothing::: YES!!
            TempString = Regex.Replace(FilenameIn, "[0-9]", string.Empty);

            return TempString;
        }
        //--------------------------------------------------
        // GET JUST NUMBER PORTION OF FILENAME ::
        //---------------------------------------------------
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
        // PICK FOLDER::
        public void ChooseFolder()
        {
            if (MyFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                string MyPath = MyFolderBrowser.SelectedPath;
                MyFolderBox.Text = MyPath;
                big_list_box.Text = GetFolderFilesIntoString(MyPath);

                MyFilesRAW = new List<string>(big_list_box.Text.Split(','));

                
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
            DirectoryInfo d = new DirectoryInfo(MyFolder); //Assuming Test is your Folder
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
            string LastName;
            string CurrentName;
            int j = 0; // Iterator for Sequence block count :: 
            for (var i = 0; i < MyFilesRAW.Count; i++)
            {
                if (i == 0) {
                    LastName = MyFilesRAW[i];
                    MyFilesShort[j] = FileNameCleaned(MyFilesRAW[i]);
                }

                if (i > 0)
                {
                    CurrentName = MyFilesRAW[i];
                    MyFilesShort[j] = FileNameCleaned(MyFilesRAW[i]);
                    j += 1;
                }

                if (i > 0 && MyFilesRAW[i] != MyFilesRAW[i - 1])
                {
                    LastName = MyFilesRAW[i];
                    CurrentName = MyFilesRAW[i];
                }


            }
            for (var i = 0; i < MyFilesShort.Count; i++)
            {
                DebugOutBox.AppendText(MyFilesShort[i]);
            }
            MyFolderSequenceCount = j;

        }

        // :: ABOOOT :::
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (AboutBox1 box = new AboutBox1())
            {
                box.ShowDialog(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }

}
