using System;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml;
//调用Wiz的COM控件
using WizKMControlsLib;
using WizKMCoreLib;

namespace WizTitleFixer
{
    public partial class WizTitleFixer : Form
    {
        public WizTitleFixer()
        {
            InitializeComponent();
            this.Text = "WizTitleFixer|v1.0";
            tbParts.Text=GetConfigValue("myReg");
          
        }

        int total;
        int progress;
        static  StringBuilder sb = new StringBuilder(64);
        private WizKMCoreLib.WizDatabase wizdb = new WizKMCoreLib.WizDatabase();
        private WizKMCoreLib.WizDocument wizdoc = new WizDocument();
       
        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            string str;
            str = tbParts.Text;
            SetConfigValue(str);
            
            wizdb.Open("");
            progress = 0;
            total = wizdb.GetAllDocuments().Count;
            progressBar1.Minimum = progress;
            progressBar1.Maximum = total;

            foreach (var  doc in wizdb.GetAllDocuments())
            {
                    doc.ChangeTitleAndFileName(TitleFixer(doc.Title, str));
                    progress++;
                    progressBar1.Value = progress;
            }

            wizdb.Close();
            lbFixedTitles.Items.Clear();
            if (sb.Length>0)
            {
                string[] strs = sb.ToString().Split('\t');
                foreach (var s in strs)
                    lbFixedTitles.Items.Add(s);
            }
            else
                lbFixedTitles.Items.Add("暂时没有找到可以清理的标题");
        }


        /// <summary>
        /// 將包含part的字符串清理掉
        /// </summary>
        /// <param name="str">源字符 串</param>
        /// <param name="part">被清理字符串(支持正則)</param>
        /// <returns></returns>
        static string TitleFixer(string str, string part)
        {
          
             
            string[] s = part.Split(';');
            foreach (var s1 in s)
            {
                if (Regex.Replace(str, s1, "", RegexOptions.IgnoreCase).Length<str.Length)
                {
                     sb.Append(str + "\t");
                     str=Regex.Replace(str, s1, "",RegexOptions.IgnoreCase);
                }
                
            }
            //if (str.Length == 0)
            //    return "ROM";
            //else
                return str;
        }
        

        private void btnHelp_Click(object sender, EventArgs e)
        {
            StringBuilder strb = new StringBuilder();
            strb.Append("被清理词组请用';'分开\r\n");
            strb.Append("支持正则,默认将清理词组替换为空\r\n");
            strb.Append("已知BUG:当替换完成把标题替换为空时,会报错\r\n");
            MessageBox.Show(strb.ToString());
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
          //  wizdb.BackupIndex();
            wizdb.Open("");
           // MessageBox.Show(wizdb.DatabasePath.ToString());
            wizdb.BackupIndex();
            MessageBox.Show("以系统日期-数字形式备份的db\r\n最多三个一天");
            wizdb.Close();
        }


        internal static string GetConfigValue(string key)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Application.ExecutablePath + ".config");

            XmlElement xElem = xmlDoc.SelectSingleNode("/configuration/"+key+"") as XmlElement;
            if (xElem != null)
                return xElem.InnerText;
            else
                return string.Empty;
        }

        internal static void SetConfigValue(string key)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Application.ExecutablePath + ".config");

            XmlElement xElem = xmlDoc.SelectSingleNode("/configuration/myReg") as XmlElement;
            if (xElem != null)
                xElem.InnerText = key;
            xmlDoc.Save(Application.ExecutablePath + ".config");
             
        }
      
    }
}
