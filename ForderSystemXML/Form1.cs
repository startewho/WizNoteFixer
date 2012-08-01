using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ForderSystemXML
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent( );
        }
        private XmlDocument xmlDoc;

        private void button1_Click(object sender, EventArgs e)
        {

            string strPath = "F:\\Vim\\";

            xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<Directory></Directory>");

            try
            {
                DirectoryInfo d1 = new DirectoryInfo(strPath);
                FileSystemInfo[] fsi = d1.GetFileSystemInfos();
     
                foreach (FileSystemInfo fs in fsi)
                {
                    XmlNode xn = xmlDoc.SelectSingleNode("Directory");
                    if (fs is DirectoryInfo)
                    {
                        
                        XmlElement xe = xmlDoc.CreateElement("Directory");
                        XmlAttribute xa1 = xmlDoc.CreateAttribute("Path");
                        XmlAttribute xa2 = xmlDoc.CreateAttribute("Size");
                        xa1.Value = fs.FullName;
                        xa2.Value = GetDirectSize(fs.FullName).ToString();
                        xe.Attributes.Append(xa1);
                        xe.Attributes.Append(xa2);
                        xn.AppendChild(xe);
                        //循环遍历，传递当前的节点是关键，因为这个原因搞了大半天
                        LoopDirectory(fs.FullName, xe);
                    }
                    else
                    {
                        FileInfo f1 = new FileInfo(fs.FullName);

                        XmlElement xe = xmlDoc.CreateElement("File");
                        XmlAttribute xa1 = xmlDoc.CreateAttribute("Path");
                        XmlAttribute xa2 = xmlDoc.CreateAttribute("Size");
                        xa1.Value = fs.FullName;
                        xa2.Value = f1.Length.ToString();
                        xe.Attributes.Append(xa1);
                        xe.Attributes.Append(xa2);

                        xn.AppendChild(xe);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                xmlDoc.Save("fileInfo.xml");
            }
        }

        //遍历所给路径的文件夹，并在当前的XmlElement处创建节点
        private void LoopDirectory(string strPath,XmlElement ele)
        {
            DirectoryInfo d1 = new DirectoryInfo(strPath);
            FileSystemInfo[] fsi = d1.GetFileSystemInfos();
            foreach (FileSystemInfo fs in fsi)
            {
                if (fs is DirectoryInfo)
                {
                    XmlElement xe = xmlDoc.CreateElement("Directory");
                    XmlAttribute xa1 = xmlDoc.CreateAttribute("Path");
                    XmlAttribute xa2 = xmlDoc.CreateAttribute("Size");
                    xa1.Value = fs.FullName;
                    xa2.Value = GetDirectSize(fs.FullName).ToString();
                    xe.Attributes.Append(xa1);
                    xe.Attributes.Append(xa2);

                    ele.AppendChild(xe);
                    //循环遍历
                    LoopDirectory(fs.FullName,xe);
                }
                else
                {
                    FileInfo f1 = new FileInfo(fs.FullName);
                    XmlElement xe = xmlDoc.CreateElement("File");
                    XmlAttribute xa1 = xmlDoc.CreateAttribute("Path");
                    XmlAttribute xa2 = xmlDoc.CreateAttribute("Size");
                    xa1.Value = fs.FullName;
                    xa2.Value = f1.Length.ToString();
                    xe.Attributes.Append(xa1);
                    xe.Attributes.Append(xa2);

                    ele.AppendChild(xe);
                }
            }
        }

        //获取一个文件夹的大小，这里借鉴别人的代码
        private long GetDirectSize(string filePath)
        {
            long temp = 0;
            if (File.Exists(filePath) == false)//判断当前路径所指向的是否为文件
            {
                string[] str1 = Directory.GetFileSystemEntries(filePath);
                foreach (string s1 in str1)
                {
                    temp += GetDirectSize(s1);
                }
            }
            else
            {
                //定义一个FileInfo对象,使之与filePath所指向的文件向关联,以获取其大小
                FileInfo fileInfo = new FileInfo(filePath);
                return fileInfo.Length;
            }
            return temp;
        }

       }

   
}
      


