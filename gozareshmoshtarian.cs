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

namespace foroshgahlebas
{
    public partial class gozareshmoshtarian : Form
    {
        public gozareshmoshtarian()
        {
            InitializeComponent();
        }

        private void gozareshkarkonan_Load(object sender, EventArgs e)
        {

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showgrid();
        }

        private void showgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            string name = txtfullname.Text.Trim();
            long tell = txtnumber.ConvertInt64();
            dataGridView1.DataSource = db.context.customers.Where(p => p.fullname.Contains(name) && (p.phonenumber == tell || tell == 0)).Select(p => new { p.fullname, p.phonenumber, address = p.address.city + " " + p.address.street + " " + p.address.postalcode }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(Application.StartupPath + "/Report3.mrt");
            report.RegBusinessObject("users", dataGridView1.DataSource);
            report.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
