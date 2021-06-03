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
        byte stored_age;
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
            
            stored_age = byte.Parse(age.Text);

            if (male.Checked)
            {
                stored_sex = male.Text;
            }
            else
            {
                stored_sex = female.Text;
            }

            stored_contactno = contactNo.Text;

            stored_email = email.Text;

            stored_address = address.Text;

            StreamWriter outputFile;
            outputFile = File.AppendText(fullName + ".txt");
            outputFile.WriteLine("Full Name: " + fullName);
            outputFile.WriteLine("Age: " + stored_age + " years old");
            outputFile.WriteLine("Sex: " + stored_sex);
            outputFile.WriteLine("Contact Number: " + stored_contactno);
            outputFile.WriteLine("Email Address: " + stored_email);
            outputFile.WriteLine("Address: " + stored_address);
            outputFile.Close();
        }
    }
}
