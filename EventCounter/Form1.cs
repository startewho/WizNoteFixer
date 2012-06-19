using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventCounter
{
    public partial class Form1 : Form
    {
        Count oCounter = new Count();
        public Form1()
        {
            InitializeComponent();

            oCounter.NumberReached += new EventHandler<NumberReachedEventArgs>(oCounter_NumberReached);
            oCounter.NumberReached += new EventHandler<NumberReachedEventArgs>(oCounter_NumberReached2); 
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (tbCountTo.Text == "" ||tbReachTo.Text == "")
                return;
            oCounter.CountTo(Convert.ToInt32(tbCountTo.Text), Convert.ToInt32(tbReachTo.Text)); 
        }

        private void oCounter_NumberReached(object sender, NumberReachedEventArgs e)
        {
            MessageBox.Show("Reached: " + e.ReachedNumber.ToString());
        }
        private void oCounter_NumberReached2(object sender, NumberReachedEventArgs e)
        {
            MessageBox.Show("Reached2: " + e.ReachedNumber.ToString());
        }

        private void btnRemoveDelegate_Click(object sender, System.EventArgs e)
        {
            oCounter.NumberReached -= new  EventHandler<NumberReachedEventArgs>(oCounter_NumberReached2);
            oCounter.CountTo(Convert.ToInt32(tbCountTo.Text), Convert.ToInt32(tbReachTo.Text));
        }
    }
}
