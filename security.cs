using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using foroshgahlebas.database;
using System.Windows.Forms;
namespace System
{
 
        public static class SecurityManagment
        {
            public static user useronline { get; private set; }
            public static DateTime logintime { get; private set; }
            public static void checkautenticate(string Username, string Password)
            {
                useronline = db.context.users.Include("roles").SingleOrDefault(p => p.username == Username && p.password == Password);
                if (useronline == null)
            {
                throw new sqlerror.eerror();   
            }
                logintime = DateTime.Now;

            }

            public static bool checkautorizeforonlineUser(int RoleID)
            {

                return useronline.roles.Any(p => p.id == RoleID);
           }

        
    }
}
