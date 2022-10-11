using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using foroshgahlebas.database;

namespace foroshgahlebas
{
    public partial class gozareshforosh : Form
    {
        public gozareshforosh()
        {
            InitializeComponent();
        }

        private void namemarket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showgrid();
        }

        private void showgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            int id = txtfacktor.ConvertInt32();
            string name = cusname.Text.Trim();
            dataGridView1.DataSource = db.context.factors.Where(p => (p.id == id || id == 0) && p.customer.fullname.Contains(name) && (p.date > dateTimePickerX1.SelectedDateInDateTime && p.date < dateTimePickerX2.SelectedDateInDateTime)).Select(p=> new {p.id,p.customer.fullname,p.date,p.payment }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(Application.StartupPath + "/Report1.mrt");
            report.RegBusinessObject("foodstuf", dataGridView1.DataSource);
            report.Show();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            List<dress> checklist = db.context.dresses.ToList();
            foreach (dress item in checklist)
            {
                if (item.number < 5)
                {

                    MessageBox.Show("لباس " + item.name + " به تعداد کمی در انبار وجود دارد لطفا در صورت فروش زیاد آن را افزایش دهید", "اطلاعیه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
