using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fill_form_Click(object sender, EventArgs e)
        {
            bar_time.Start();

        }

        private void bar_time_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                bar_time.Stop();
                this.Hide();
                Fill_up fill_Up = new Fill_up();
                fill_Up.Show();
            }
        }
    }
}
