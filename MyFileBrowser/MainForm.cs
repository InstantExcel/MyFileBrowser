using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

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
        public int Folder_TotalFileCount;

        

        

        public List<SeqImgObjXML> SeqList = new List<SeqImgObjXML>();
        public int ItemNameCount = 0;
        public int FileSeqNameCountIterator = 0;
   


        public MainForm()
        {
            InitializeComponent();
            MyPath= Directory.GetCurrentDirectory();
        }

        //-------------------------------------------------------
        // :: RETURN INDEX OF FILENAME 
        //----------------------------------------------------
        public int GetFileNameIndex (string FileNameIn , Array MyArray)
        {

            return -1;
        }

        //-------------------------------------------------------
        // :: GET JUST TEXT PORTION, MASK NUMBER AS XXXX
        //----------------------------------------------------

        public String FileNameCleaned (string FilenameIn)
        {
            string TempString ;
            
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
            int TempNum=1;
            int TempNumB; 
            TempString = Regex.Match(FilenameIn, @"\d+").Value;
            if (int.TryParse(TempString, out TempNumB)) {
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
                groupBox1.Text = "Folder "+MyPath+" searched @ " + DateTime.Now.ToString()+ " found  "+ ItemNameCount.ToString() + " items." ;
                bHasFolderBeenPicked = true;
            }
        }


        //-------------------------------------------------------------------------------
        //--- 
        //---   :: GET INTO COMMA SEPARATED LIST .. .
        //--- 
        //-------------------------------------------------------------------------------
        public string GetFolderFilesIntoString ( string MyFolder)
        {
            DirectoryInfo d = new DirectoryInfo(MyFolder); //Assuming Test is your Folder
            MyPickedFiles = d.GetFiles("*.png"); //Getting Text files

            Folder_TotalFileCount = MyPickedFiles.Length;

            string str = "";


            
            foreach (FileInfo file in MyPickedFiles)
            {   
                if (str.Length > 0)
                    {
                        str = str + ", "  +Environment.NewLine +   file.Name;
                    }
                else
                    {
                        str = file.Name;
                    }
                
            }
            
            return str;
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
            
            if (bHasFolderBeenPicked && ItemNameCount > 0)
            {
//                MessageBox.Show("I have " + ItemNameCount.ToString() + " items. load? " );

                for(int i = 1; i < ItemNameCount+1; i++) 
                {
                    string[] row = { "Name Test" + i.ToString(), "A","B","C" };
                    var listViewItem = new ListViewItem(row);
                    DataListView.Items.Add(listViewItem);
                }
            }
        }

     
    }

}
