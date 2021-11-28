using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyFileBrowser
{
    public class SeqImgObjXML
    {
        public int MySeqID { get; set; }
        public string MySeqName { get; set; }
        public int MySeqFrameStart{ get; set; }
        public int MySeqFrameEnd { get; set; }
        public int MySeqFrameCount { get; set; }
        public int MySeqSaveDate { get; set; }
    }
}
