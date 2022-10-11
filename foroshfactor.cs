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
using Stimulsoft.Report;
namespace foroshgahlebas
{
    
    public partial class foroshfactor : Form
    {
        factor newfactor = null;
        dress_factor newdressfactor = null;
        public List<long> Total_Amount = new List<long>();
        public long suem = 0;
        int numbers;


        


        public foroshfactor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newcustomer form = new newcustomer();
            form.ShowDialog();

            combomoshtari.DataSource = db.context.customers.ToList();
            combomoshtari.ValueMember = "id";
            combomoshtari.DisplayMember = "fullname";
            combomoshtari.SelectedIndex = -1;
        }

        private void textnnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            int dressid = Convert.ToInt32(dataGridView1["dressid", e.RowIndex].Value);
            int factorid = Convert.ToInt32(dataGridView1["factorid", e.RowIndex].Value);
            newdressfactor = db.context.dress_factor.Where(p => p.dressid == dressid && p.factorid == factorid).SingleOrDefault();
            newfactor = db.context.factors.Where(p => p.id == factorid).SingleOrDefault();
            combomoshtari.SelectedValue = newfactor.customerid;
            combokala.SelectedValue = newdressfactor.dressid;
            numbers = newdressfactor.number;
            textnnumber.Text = newdressfactor.number.ToString();


        }

        private void sabt_Click(object sender, EventArgs e)
        {
            if(combomoshtari.SelectedIndex==-1 && (combokala.SelectedIndex==-1 || textnnumber.Text == null))
            {
                mymessagebox.errormessage("موارد خواسته شده را وارد کنید");
                return;
            }
           
            if(newfactor == null)
            {
                newfactor = new factor();
                db.context.factors.Add(newfactor);
                newfactor.payment = 0;
                Total_Amount = new List<long>();
                suem = 0;
            }

            newdressfactor = new dress_factor();
            newfactor.customerid = combomoshtari.GetValue();
            newfactor.date = dateTimePickerX1.SelectedDateInDateTime;
            int kalavalue = combokala.GetValue();
            dress selected = db.context.dresses.SingleOrDefault(p => p.id == kalavalue);
       
            int tedad= selected.number - int.Parse(textnnumber.Text.Trim());
         

            if (tedad < 0)
            {
                mymessagebox.errormessage("موجودی کافی نیست");
                newdressfactor = null;
                selected = null;
                return;
            }

            else
            {
                db.context.dress_factor.Add(newdressfactor);
                newdressfactor.factorid = newfactor.id;
                newdressfactor.dressid = combokala.GetValue();
                newdressfactor.number = int.Parse(textnnumber.Text.Trim());
                newdressfactor.payment = long.Parse(newdressfactor.number.ToString()) * selected.payment;
                selected.number = selected.number - newdressfactor.number;
                newfactor.payment = +newdressfactor.payment;

                Total_Amount.Add(newdressfactor.payment);

                suem = Total_Amount.Sum();
                feee.Text = Total_Amount.Sum().ToString();
                newfactor.payment = Total_Amount.Sum();
                db.context.SaveChanges();
                showgrid();
                textBoxMount.Text = feee.Text;
                newdressfactor = null;
                combokala.SelectedIndex = -1;
                textnnumber.Text = null;


            }
            






        }

        private void showgrid()
        {
            if (newfactor != null)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = db.context.dress_factor.Where(p => p.factorid == newfactor.id).Select(p => new { p.factorid, p.dressid, p.dress.name, p.number, p.payment }).ToList();
            }

            else
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = db.context.dress_factor.Where(p => p.factorid == 0).Select(p => new { p.factorid, p.dressid, p.dress.name, p.number, p.payment }).ToList();


            }


        }

        private void edite_Click(object sender, EventArgs e)
        {
            dress selected = db.context.dresses.SingleOrDefault(p => p.id == newdressfactor.dressid);
            selected.number += newdressfactor.number;
            db.context.dress_factor.Remove(newdressfactor);
            newfactor.payment -= newdressfactor.payment;
            feee.Text = newfactor.payment.ToString();
            db.context.SaveChanges();

            newdressfactor = null;
            selected = null;




            newdressfactor = new dress_factor();
            newfactor.customerid = combomoshtari.GetValue();
            newfactor.date = dateTimePickerX1.SelectedDateInDateTime;
        
            int kalavalue = combokala.GetValue();
            dress selected1 = db.context.dresses.SingleOrDefault(p => p.id == kalavalue);

            int tedad = selected1.number - int.Parse(textnnumber.Text.Trim());

            if (tedad < 0)
            {
                mymessagebox.errormessage("موجودی کافی نیست");
                newdressfactor = null;
                selected1 = null;
                return;
            }



            else
            {

                db.context.dress_factor.Add(newdressfactor);
                newdressfactor.factorid = newfactor.id;
                newdressfactor.dressid = combokala.GetValue();
                newdressfactor.number = int.Parse(textnnumber.Text.Trim());
                newdressfactor.payment = long.Parse(newdressfactor.number.ToString()) * selected1.payment;
                selected1.number = selected1.number - newdressfactor.number;

                newfactor.payment = +newdressfactor.payment;
                feee.Text = newfactor.payment.ToString();
                db.context.SaveChanges();
                showgrid();
                textBoxMount.Text = feee.Text;
                newdressfactor = null;
                combokala.SelectedIndex = -1;
                textnnumber.Text = null;
                mymessagebox.successmessage("تغییرات اعمال شد");

            }


        }

        private void delete_Click(object sender, EventArgs e)
        {
            dress selected = db.context.dresses.SingleOrDefault(p => p.id == newdressfactor.dressid);
            selected.number += newdressfactor.number;
            db.context.dress_factor.Remove(newdressfactor);
            newfactor.payment -= newdressfactor.payment;
            feee.Text = newfactor.payment.ToString();
            db.context.SaveChanges();
            showgrid();
            textBoxMount.Text = feee.Text;
            combokala.SelectedIndex = -1;
            textnnumber.Text = null;
            newdressfactor = null;
            selected = null;
            mymessagebox.successmessage("حذف شد");
        }

        private void foroshfactor_Load(object sender, EventArgs e)
        {
            showgrid();
            showcombo();
        }

        private void showcombo()
        {

            combokala.DataSource = db.context.dresses.ToList();
            combokala.ValueMember = "id";
            combokala.DisplayMember = "name";
            combokala.SelectedIndex = -1;

            combomoshtari.DataSource = db.context.customers.ToList();
            combomoshtari.ValueMember = "id";
            combomoshtari.DisplayMember = "fullname";
   
            combomoshtari.SelectedIndex = -1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sabtkoli_Click(object sender, EventArgs e)
        {




            StiReport report = new StiReport();
            report.Load(Application.StartupPath + "/Report2.mrt");
            report.RegBusinessObject("factor", dataGridView1.DataSource);
            report.Show();
        }

        private void combokala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
