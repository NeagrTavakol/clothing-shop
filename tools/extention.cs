using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace System
{
    public static class ExtensionMethods
    {

        public static Int64 ConvertInt64(this TextBoxBase textBox)
        {
            return textBox.Text.Trim() == "" ? 0 : Convert.ToInt64(textBox.Text.Trim());
        }
        public static Int32 ConvertInt32(this TextBoxBase textBox)
        {
            return textBox.Text.Trim() == "" ? 0 : Convert.ToInt32(textBox.Text.Trim());
        }
        public static Int16 ConvertInt16(this TextBoxBase textBox)
        {
            return textBox.Text.Trim() == "" ? (Int16)0 : Convert.ToInt16(textBox.Text.Trim());
        }

        public static int GetValue(this ComboBox combo)
        {
            return Convert.ToInt32(combo.SelectedValue);
        }
    }
}
