using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using foroshgahlebas.database;
using ValidationComponents;

namespace foroshgahlebas
{
    public partial class newuser : Form
    {
        user newusers = null;
        address newaddress = null;


        public newuser()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void newuser_Load(object sender, EventArgs e)
        {
            showgrid();
        }

        private void showgrid()
        {
            comborole.DataSource = db.context.roles.ToList();
            comborole.DisplayMember = "name";
            comborole.ValueMember = "id";
            comborole.SelectedIndex = -1;





            //  dataGridView1.AutoGenerateColumns = false;
            //  dataGridView1.DataSource = db.context.users.Select(p => new { p.id, p.fullname, p.codemeli, p.password, p.phonenumber, p.username, address = p.address.city + " " + p.address.street + " " + p.address.postalcode, p.addresid ,rolename=p.role.name}).ToList();


        }

        private void sabt_Click(object sender, EventArgs e)
        {
            if (txtstreet.Text == null || txtcity.Text == null || txtpostalcode.Text == null || txtcodemeli.Text == null || txtnumber.Text == null || txtname.Text == null || txtpassword.Text == null || txtusername == null || comborole.SelectedIndex == -1)
            {

                mymessagebox.errormessage("مقادیر خواسته شده را وارد کنید");
                return;

            }

            newaddress = new address();
            db.context.addresses.Add(newaddress);
            newaddress.city = txtcity.Text.Trim();
            newaddress.street = txtstreet.Text.Trim();
            newaddress.postalcode = long.Parse(txtpostalcode.Text.Trim());
            newusers = new user();
            db.context.users.Add(newusers);
            newusers.fullname = txtname.Text.Trim();
            newusers.codemeli = long.Parse(txtcodemeli.Text.Trim());
            newusers.phonenumber = long.Parse(txtnumber.Text.Trim());
            newusers.addresid = newaddress.id;
            newusers.username = txtusername.Text.Trim();
            newusers.password = txtpassword.Text.Trim();
            var role = db.context.roles.Find(comborole.GetValue());

            newusers.roles.Add(role);

            db.context.SaveChanges();
            clearevrything();




        }

        private void clearevrything()
        {
            txtcity.Text = txtcodemeli.Text = txtname.Text = txtnumber.Text = txtpassword.Text = txtpostalcode.Text = txtstreet.Text = txtusername.Text = null;
            newaddress = null;
            newusers = null;
            showgrid();
            mymessagebox.successmessage();
        }
    }
}
