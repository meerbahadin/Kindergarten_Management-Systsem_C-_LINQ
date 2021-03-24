using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kindergarten2
{
    class global_username
    {
        public static string _user = "";

        public static string GlobalUsername
        {
            get { return _user; }
            set { _user = value; }
        }

        public static Boolean _mode;
        public static Boolean GlobalMode
        {
            get { return _mode; }
            set { _mode = value; }
        }
    }
}
