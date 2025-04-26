using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpringCapstone
{
    public partial class testResults : Form
    {
        public testResults(TimeSpan totalTime)
        {
            InitializeComponent();

            // Display the total time in a label or other control
            totalTimeLBL.Text = totalTime.ToString(@"hh\:mm\:ss"); // Format as HH:MM:SS
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            projectManager projectManager = new projectManager();
            projectManager.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void totalTimeLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
