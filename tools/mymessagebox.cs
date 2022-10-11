using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    class mymessagebox
    {
        public static void successmessage(string mess = "عملیات  با موفقیت ثبت شد")
        {
            MessageBox.Show(mess, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void errormessage(string mess = "لطفا مقداری  را برگزینید")
        {
            MessageBox.Show(mess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool question(string mess = "ایا میخواهید  مورد انتخاب شده را حذف کنید؟")
        {
            DialogResult soal = MessageBox.Show(mess, "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soal == DialogResult.No)
            {
                return false;
            }
            return true;
        }
    }
}
