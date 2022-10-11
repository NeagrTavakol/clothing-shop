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
    public partial class newproducer : Form
    {
        producer newproducers = null;
        producer selectedproducer = null;

        address newaddress = null;
        address selectedaddress = null;
        public newproducer()
        {
            InitializeComponent();
        }

     

        private void newproducer_Load(object sender, EventArgs e)
        {
            showgrid();
        }

        private void showgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.context.producers
                .Select(p => new { p.id, p.producername, p.telephone, address = p.address.city + " " + p.address.street + " " + p.address.postalcode })
                .ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(txtstreet.Text==null|| txtcity.Text == null || txtpostalcode.Text == null || txtpname.Text == null || txtnumber.Text == null)
            {

                mymessagebox.errormessage("مقادیر خواسته شده را وارد کنید");
                return;

            }


            newproducers = new producer();
            newaddress = new address();
            db.context.producers.Add(newproducers);
            db.context.addresses.Add(newaddress);
            newaddress.city = txtcity.Text.Trim().ToString();
            newaddress.street = txtstreet.Text.Trim().ToString();
            newaddress.postalcode = long.Parse(txtpostalcode.Text.Trim());

            newproducers.producername = txtpname.Text.Trim().ToString();
            newproducers.telephone = long.Parse(txtnumber.Text.Trim());
            newproducers.addressid = newaddress.id;

            db.context.SaveChanges();
            cleareevrything();
          

            showgrid();
        }

        private void cleareevrything()
        {
            newaddress = null;
            newproducers = null;
            selectedaddress = null;
            selectedproducer = null;
            txtstreet.Text = null;
            txtcity.Text = null;
            txtpostalcode.Text = null;
            txtpname.Text= null;
            txtnumber.Text = null;
            mymessagebox.successmessage();
            showgrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtpostalcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
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
            selectedproducer = db.context.producers.Where(p => p.id == name).SingleOrDefault();
            selectedaddress = db.context.addresses.Where(p => p.id == selectedproducer.addressid).SingleOrDefault();

            txtpname.Text = selectedproducer.producername.ToString();
            txtnumber.Text = selectedproducer.telephone.ToString();
            txtcity.Text = selectedaddress.city.ToString();
            txtstreet.Text = selectedaddress.street.ToString();
            txtpostalcode.Text = selectedaddress.postalcode.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtstreet.Text == null || txtcity.Text == null || txtpostalcode.Text == null || txtpname.Text == null || txtnumber.Text == null)
            {

                mymessagebox.errormessage("مقادیر خواسته شده را وارد کنید");
                return;

            }
            if (selectedaddress==null || selectedproducer == null)
            {
                mymessagebox.errormessage();
                return;
            }

            selectedaddress.city = txtcity.Text.Trim().ToString();
            selectedaddress.street = txtstreet.Text.Trim().ToString();
            selectedaddress.postalcode = long.Parse(txtpostalcode.Text.Trim());

            selectedproducer.producername = txtpname.Text.Trim().ToString();
            selectedproducer.telephone = long.Parse(txtnumber.Text.Trim());
            selectedproducer.addressid = selectedaddress.id;

            db.context.SaveChanges();
            cleareevrything();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedaddress == null || selectedproducer == null)
            {
                mymessagebox.errormessage();
                return;
            }
            db.context.producers.Remove(selectedproducer);
            db.context.addresses.Remove(selectedaddress);
            db.context.SaveChanges();
            cleareevrything();
        }
    }
}
