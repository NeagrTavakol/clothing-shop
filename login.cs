using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foroshgahlebas
{
    public partial class login : Form
    {
        bool isopen = true;
        public login()
        {
            InitializeComponent();
        }

        private void closss_Click(object sender, EventArgs e)
        {
            isopen = false;
            Application.Exit();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isopen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecurityManagment.checkautenticate(textuser.Text.Trim(), textpass.Text.Trim());
            isopen = false;
            Close();
        }

        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Show_Hide.Checked)
            {
                textpass.UseSystemPasswordChar = true;
            }
            else
            {
                textpass.UseSystemPasswordChar = false;
            }
        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
