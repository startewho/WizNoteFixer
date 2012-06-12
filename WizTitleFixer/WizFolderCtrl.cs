using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//调用Wiz的COM控件
using WizKMControlsLib;
using WizKMCoreLib;

namespace WizTitleFixer
{
    class WizFolderCtrl
    {
        WizDatabase wizdb;
        public string[] folders { set; get; }
        public WizFolderCtrl()
        {
             wizdb = new WizKMCoreLib.WizDatabase();
            //WizDocument wizdoc = new WizDocument();
            wizdb.Open("");
            folders = wizdb.GetAllTagsName().Split(';');
            wizdb.Close();
        }

        //public string[] lists(string str)
        //{
        //    string[] s;
        //    wizdb.Open("");
        //    foreach (var l in wizdb.GetTagByName(str, false, str))
        //    {
                
        //    }
        //    wizdb.Close();

        }
    }
