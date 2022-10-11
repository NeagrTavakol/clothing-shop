using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using foroshgahlebas.database;

namespace System
{


    public static class db
    {
        private static foroshgahlebasEntities _Context = new foroshgahlebasEntities();

        public static foroshgahlebasEntities context
        {
            get
            {
                return _Context;
            }
        }
    }
}