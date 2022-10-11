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
    public partial class Formdress : Form
    {

        dress newdress = null;
        dress selecteddress = null;
        public Formdress()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Formdress_Load(object sender, EventArgs e)
        {
            showgridview();
        }

        private void showgridview()
        {
           
            comboproducer.DataSource = db.context.producers.ToList();
            comboproducer.ValueMember = "id";
            comboproducer.DisplayMember = "producername";
            comboproducer.SelectedIndex = -1;

            
           combotype.DataSource = db.context.types.ToList();
            combotype.ValueMember = "id";
            combotype.DisplayMember = "typename";
            combotype.SelectedIndex = -1;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.context.dresses
                .Select(p =>new { p.id, p.name, p.number, p.payment, p.producer.producername, p.size, p.type.typename,p.color })
                .ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            newproducer form = new newproducer();
            form.ShowDialog();

            comboproducer.DataSource = db.context.producers.ToList();
            comboproducer.ValueMember = "id";
            comboproducer.DisplayMember = "producername";
            comboproducer.SelectedIndex = -1;


        }

      

        private void txtsize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
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
            selecteddress = db.context.dresses.Where(p => p.id == name).SingleOrDefault();
            txtmodel.Text = selecteddress.name;
            txtcolor.Text = selecteddress.color;
            txtnumber.Text = selecteddress.number.ToString();
            txtprice.Text = selecteddress.payment.ToString();
            txtsize.Text = selecteddress.size.ToString();
            comboproducer.SelectedValue = selecteddress.producerid;
            combotype.SelectedValue = selecteddress.typeid;



        }

        private void btnregisterdress_Click(object sender, EventArgs e)
        {

            if(txtmodel.Text==null|| txtnumber.Text==null|| txtcolor.Text==null|| txtprice.Text==null|| txtsize.Text==null|| comboproducer.SelectedIndex == -1 || combotype.SelectedIndex == -1)
            {

                mymessagebox.errormessage("مقادیر خواسته شده را وارد کنید");
                return;
            }


            newdress = new dress();
            db.context.dresses.Add(newdress);
            newdress.name = txtmodel.Text.Trim();
            newdress.number = int.Parse(txtnumber.Text.Trim());
            newdress.color = txtcolor.Text.Trim();
            newdress.payment = long.Parse(txtprice.Text.Trim());
            newdress.producerid = comboproducer.GetValue();
            newdress.typeid = combotype.GetValue();
            newdress.size = double.Parse(txtsize.Text.Trim());

            db.context.SaveChanges();

            clearevrything();

        }

        private void clearevrything()
        {

            newdress = null;
            selecteddress = null;
            txtmodel.Text = null;
            txtsize.Text = null;
            txtprice.Text = null;
            txtnumber.Text = null;
            txtcolor.Text = null;
            comboproducer.SelectedIndex = -1;
            combotype.SelectedIndex = -1;
            mymessagebox.successmessage();
            showgridview();

        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            if (selecteddress == null) {
                mymessagebox.errormessage();

                return;

            }

            selecteddress.name = txtmodel.Text.Trim();
            selecteddress.number = int.Parse(txtnumber.Text.Trim());
            selecteddress.color = txtcolor.Text.Trim();
            selecteddress.payment = long.Parse(txtprice.Text.Trim());
            selecteddress.producerid = comboproducer.GetValue();
            selecteddress.typeid = combotype.GetValue();
            selecteddress.size = double.Parse(txtsize.Text.Trim());

            db.context.SaveChanges();

            clearevrything();



        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (selecteddress == null)
            {
                mymessagebox.errormessage();

                return;

            }

            db.context.dresses.Remove(selecteddress);
            db.context.SaveChanges();
            clearevrything();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
