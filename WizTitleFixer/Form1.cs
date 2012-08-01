﻿using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

//调用Wiz的COM控件
using WizKMCoreLib;

namespace WizTitleFixer
{
    public partial class WizTitleFixer : Form
    {
        public WizTitleFixer( )
        {
            InitializeComponent( );
            this.Text = "WizTitleFixer|v1.3";
            foreach (var str in GetConfigValue("myReg").Split("\r\n".ToCharArray( ), StringSplitOptions.RemoveEmptyEntries))
            {
                cmbExpress.Items.Add(str);
            }
        }

        private int total;
        private int progress;
        private static StringBuilder sb = new StringBuilder(64);
        private WizKMCoreLib.WizDatabase wizdb = new WizKMCoreLib.WizDatabase( );
        private WizKMCoreLib.WizDocument wizdoc = new WizDocument( );

        /// <summary>
        /// 將包含part的字符串清理掉
        /// </summary>
        /// <param name="str">源字符 串</param>
        /// <param name="part">被清理字符串(支持正則)</param>
        /// <returns></returns>
        private static string TitleFixer(string str, string part)
        {

            string[] s = part.Split(';');
            foreach (var s1 in s)
            {
     
                //if (Regex.Replace(str, s1, "", RegexOptions.IgnoreCase).Length < str.Length)
                string strn = Regex.Replace(str, s1, "", RegexOptions.IgnoreCase);
                if (strn.Length < str.Length)
                {
                    sb.Append(str + "\t");
                    str = strn;
                    strn = null;
                }
               
            }
            return str;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            StringBuilder strb = new StringBuilder( );
            strb.Append("被清理词组请用';'分开\r\n");
            strb.Append("支持正则,默认将清理词组替换为空\r\n");
            strb.Append("已知BUG:当替换完成把标题替换为空时,会报错\r\n");
            MessageBox.Show(strb.ToString( ));
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            //  wizdb.BackupIndex();
            wizdb.Open("");
            // MessageBox.Show(wizdb.DatabasePath.ToString());
            // wizdb.BackupIndex();

            // fi.MoveTo(
            File.Copy(wizdb.DatabasePath + "index.db", wizdb.DatabasePath + "indexbk.db", true);
            MessageBox.Show("备份在数据库文件夹下面indexbk.db");
            wizdb.Close( );
        }

        internal static string GetConfigValue(string key)
        {
            XmlDocument xmlDoc = new XmlDocument( );
            xmlDoc.Load(Application.ExecutablePath + ".config");

            string str = String.Empty;
            foreach (XmlNode xElem in xmlDoc.SelectNodes("/configuration/" + key + ""))
            {
                if (xElem != null)
                    str += xElem.InnerText + "\r\n";
            }
            return str;
        }

        internal static void SetConfigValue(string key, int itemmax)
        {
            XmlDocument xmlDoc = new XmlDocument( );
            xmlDoc.Load(Application.ExecutablePath + ".config");

            //最多可以保存9个
            Queue qu = new Queue(itemmax);

            foreach (XmlElement xe in xmlDoc.SelectNodes("/configuration/myReg"))
            {
                qu.Enqueue(xe.InnerText);
            }

            if (qu.Count > 9)
            {
                qu.Dequeue( );
                qu.TrimToSize( );
            }

            //去除重复的.
            if (!qu.Contains(key))
                qu.Enqueue(key);

            var root = xmlDoc.SelectSingleNode("configuration");

            //主要是了保证不重复
            root.RemoveAll( );

            foreach (string str in qu)
            {
                XmlElement xElem = xmlDoc.CreateElement("myReg");
                xElem.InnerText = str;
                root.AppendChild(xElem);
            }
            xmlDoc.Save(Application.ExecutablePath + ".config");
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            lbPre.Items.Clear( );
            lbRes.Items.Clear( );

            wizdb.Open("indxbk.db");

            progress = 0;
            total = wizdb.GetAllDocuments( ).Count;
            progressBar1.Minimum = progress;
            progressBar1.Maximum = total;

            //将备份db数据库还原
            File.Copy(wizdb.DatabasePath + "indexbk.db", wizdb.DatabasePath + "index.db", true);

            //关闭备份数据库,打开新数据库
            wizdb.Close( );
            wizdb.Open("");

            foreach (var doc in wizdb.GetAllDocuments( ))
            {
                // if ((doc.Title + ".ziw") != doc.Name)

                //doc.Name = doc.Title + ".ziw";

                string s = doc.Title;
               
                progress++;
                progressBar1.Value = progress;
            }
            wizdb.Close( );
        }

        public void ConnectData( )
        {
          
            wizdb.Open("");
            progress = 0;
            total = wizdb.GetAllDocuments( ).Count;
            progressBar1.Minimum = progress;
            progressBar1.Maximum = total;
        }

        private void btnRepView_Click(object sender, EventArgs e)
        {
            cmbExpress.Items.Clear( );
            SetConfigValue(cmbExpress.Text, 9);
            foreach (var str in GetConfigValue("myReg").Split("\r\n".ToCharArray( ), StringSplitOptions.RemoveEmptyEntries))
            {
                cmbExpress.Items.Add(str);
            }

            ConnectData( );
            lbPre.Items.Clear( );
            lbRes.Items.Clear( );
            sb.Clear( );
            string[] titlles = wizdb.AllDocumentsTitle.Split('\n');
            foreach (var title in titlles)
            {
                string s = TitleFixer(title, cmbExpress.Text);

                progress++;
                progressBar1.Value = progress;
            }
            if (sb.Length > 0)
            {
                string[] strs = sb.ToString( ).Split('\t');

                foreach (var s in strs)
                {
                    lbPre.Items.Add(s);
                    lbRes.Items.Add(TitleFixer(s, cmbExpress.Text));
                }
            }
            wizdb.Close( );
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            ConnectData( );

            foreach (var doc in wizdb.GetAllDocuments( ))
            {
              
                try
                {
                    doc.ChangeTitleAndFileName(TitleFixer(doc.Title, cmbExpress.Text));
                }

                catch (Exception ex)
                {
                    ex.GetHashCode( );
                }

                progress++;
                progressBar1.Value = progress;
            }

            wizdb.Close( );
            //lbPre.Items.Clear();
            //if (sb.Length > 0)
            //{
            //    string[] strs = sb.ToString().Split('\t');
            //    foreach (var s in strs)
            //        lbPre.Items.Add(s);
            //}
            //else
            //    lbPre.Items.Add("暂时没有找到可以清理的标题");
        }
    }
}