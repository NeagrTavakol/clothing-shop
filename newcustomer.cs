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

namespace foroshgahlebas
{

    public partial class newcustomer : Form
    {

        customer newcustomers = null;
        customer selectedcustomer = null;


        address newaddress = null;
        address selectedaddress = null;


        public newcustomer()
        {
            InitializeComponent();
        }

        private void newcustomer_Load(object sender, EventArgs e)
        {
            showgrid();
        }

        private void showgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.context.customers
                .Select(p => new { p.id,   p.fullname, p.phonenumber, address = p.address.city + " " + p.address.street + " " + p.address.postalcode })
                .ToList();
        }

        private void sabt_Click(object sender, EventArgs e)
        {


            if (txtstreet.Text == null || txtcity.Text == null || txtpostalcode.Text == null || txtpname.Text == null || txtnumber.Text == null)
            {

                mymessagebox.errormessage("مقادیر خواسته شده را وارد کنید");
                return;

            }
            newcustomers = new customer();
            newaddress = new address();
            db.context.customers.Add(newcustomers);
            db.context.addresses.Add(newaddress);
            newaddress.city = txtcity.Text.Trim().ToString();
            newaddress.street = txtstreet.Text.Trim().ToString();
            newaddress.postalcode = long.Parse(txtpostalcode.Text.Trim());


            newcustomers.fullname = txtpname.Text.Trim().ToString();
            newcustomers.phonenumber = long.Parse(txtnumber.Text.Trim());
            newcustomers.addressid = newaddress.id;

            db.context.SaveChanges();
            cleareevrything();

        }
        private void cleareevrything()
        {
            newaddress = null;
            newcustomers = null;
            selectedaddress = null;
            selectedcustomer = null;
            txtstreet.Text = null;
            txtcity.Text = null;
            txtpostalcode.Text = null;
            txtpname.Text = null;
            txtnumber.Text = null;
            mymessagebox.successmessage();
            showgrid();
        }
        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtpostalcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            int name = Convert.ToInt32(dataGridView1["id", e.RowIndex].Value);
         selectedcustomer=   db.context.customers.Where(p => p.id == name).SingleOrDefault();
            selectedaddress = db.context.addresses.Where(p => p.id == selectedcustomer.addressid).SingleOrDefault();
           
            txtpname.Text = selectedcustomer.fullname.ToString();
            txtnumber.Text = selectedcustomer.phonenumber.ToString();
            txtcity.Text = selectedaddress.city.ToString();
            txtstreet.Text = selectedaddress.street.ToString();
            txtpostalcode.Text = selectedaddress.postalcode.ToString();


        }

        private void edite_Click(object sender, EventArgs e)
        {
            if (selectedaddress == null || selectedcustomer == null)
            {
                mymessagebox.errormessage();
                return;
            }

            selectedaddress.city = txtcity.Text.Trim().ToString();
            selectedaddress.street = txtstreet.Text.Trim().ToString();
            selectedaddress.postalcode = long.Parse(txtpostalcode.Text.Trim());

            selectedcustomer.fullname = txtpname.Text.Trim().ToString();
            selectedcustomer.phonenumber = long.Parse(txtnumber.Text.Trim());
            selectedcustomer.addressid = selectedaddress.id;

            db.context.SaveChanges();
            cleareevrything();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedaddress == null || selectedcustomer == null)
            {
                mymessagebox.errormessage();
                return;
            }
            db.context.customers.Remove(selectedcustomer);
            db.context.addresses.Remove(selectedaddress);
            db.context.SaveChanges();
            cleareevrything();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
