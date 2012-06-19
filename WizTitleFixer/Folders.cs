using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WizKMControlsLib;
using WizKMCoreLib;

namespace WizTitleFixer
{
    public partial class Folders : Form
    {
        WizFolderCtrl wizctrl ;

        public Folders()
        {
            InitializeComponent();
            wizctrl=new  WizFolderCtrl();

            foreach (WizFolder s in wizctrl.folders)
             cmbFolderList.Items.Add(s.Name);
      
        }

        private void cmbFolderList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

   
    }
}
