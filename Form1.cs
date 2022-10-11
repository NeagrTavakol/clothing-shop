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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Formdress form = new Formdress();
            form.ShowDialog();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            newuser form = new newuser();
            form.ShowDialog();
        }

        private void btnforosh_Click(object sender, EventArgs e)
        {
            foroshfactor form = new foroshfactor();
            form.ShowDialog();
        }

        private void btngozareshgiri_Click(object sender, EventArgs e)
        {
            gozareshforosh form = new gozareshforosh();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gozareshmoshtarian form = new gozareshmoshtarian();
            form.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
             login form = new login();
            form.ShowDialog();
            if (SecurityManagment.useronline != null)
            {
                checkaccesmenu();
            }
        }

        private void checkaccesmenu()
        {
            button2.Visible = SecurityManagment.checkautorizeforonlineUser(1);

            btngozareshgiri.Visible = SecurityManagment.checkautorizeforonlineUser(1);

        }
    }
}
