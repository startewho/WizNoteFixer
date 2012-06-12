using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WizTitleFixer
{
    public partial class Folders : Form
    {
        WizFolderCtrl wizctrl ;

        public Folders()
        {
            InitializeComponent();
            wizctrl=new  WizFolderCtrl();
     
            foreach(var s in wizctrl.folders)
             cmbFolderList.Items.Add(s);
      
        }

        private void cmbFolderList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

   
    }
}
