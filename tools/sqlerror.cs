 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace System

{
    class sqlerror
    {  
        public static void GetError(Exception ex)
        {
            string ErrorMessage = "خطا";
            if (ex.GetType() == typeof(eerror))
            {
                ErrorMessage = "کلمه کاربری یا رمز عبور اشتباست";
            }
            if (ex.GetType() == typeof(FormatException))
            {
                ErrorMessage = " خطای فرمت ";
            }
            if (ex.GetType() == typeof(DivideByZeroException))
            {
                ErrorMessage = "خطای تقسیم بر صفر";
            }
            if (ex.GetType() == typeof(System.Data.Entity.Infrastructure.DbUpdateException))
            {
                SqlException sql = ex.InnerException.InnerException as SqlException;
                ErrorMessage = GetSqlServerError(sql);
            }
            if (ex.GetType() == typeof(SqlException))
            {
                SqlException sql = ex as SqlException;
                ErrorMessage = GetSqlServerError(sql);
            }


            
            mymessagebox.errormessage(ErrorMessage);
        }

        private static string GetSqlServerError(SqlException sql)
        {
            string ErrorMessage = " خطای پایگاه داده ";
            if (sql.Number == 2627)
            {
                ErrorMessage = "اطلاعات تکراری است";
            }
            if (sql.Number == 547)
            {
                ErrorMessage = " به دلیل اینکه اطلاعات در قسمت های دیگر استفاده شده است ، قابل حذف نیست ";
            }
            if (sql.Number == 53 || sql.Number == 2 || sql.Number == -2)
            {
                ErrorMessage = " به منبع داده دسترسی ندارید ";
            }

            return ErrorMessage;
        }

        public class eerror : Exception
        {

        }
    }
}
