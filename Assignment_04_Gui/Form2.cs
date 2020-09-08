using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_04_Gui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            while (Form1.histories.Count > 0)
            {
                lstHistory.Items.Add(Form1.histories.Dequeue());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (Form1.histories.Count > 0)
            {
                lstHistory.Items.Add(Form1.histories.Dequeue());
            }
        }

        private void btnHistoryX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }
    }
}
