using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Fill_up : Form
    {
        string fullName;
        string stored_age;
        string stored_sex;
        string stored_email;
        string stored_contactno;
        string stored_address;

        public Fill_up()
        {
            InitializeComponent();
        }

        internal void Show(int v)
        {
            throw new NotImplementedException();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            fullName = firstName.Text + " " + lastName.Text;
           
            StreamWriter outputFile;
            outputFile = File.AppendText(fullName + ".txt");
            outputFile.WriteLine("Full Name: " + fullName);
            outputFile.Close();
        }
    }
}
