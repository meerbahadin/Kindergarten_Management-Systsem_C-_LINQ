using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kindergarten2
{
    class userClass
    {
        private static string _fullname { get; set; }
        private static string _username { get; set; }
        private static string _userRole { get; set; }

        private static string _password { get; set; }
        private static string _status { get; set; }
        private static int _id { get; set; }

        public static string getFullName()
        {
            return _fullname;
         

        }

        public static void setFullName(string fullname)
        {
            _fullname = fullname;
        }

        public static int  getUserId()
        {
            return _id;

        }

        public static void setUserId(int id)
        {
             _id = id;

        }

        public static string getUserStatus()
        {
            return _status;

        }

        public static void setUserStatus(string status)
        {
            _status = status;
        }

        public static string getUserName()
        {
            return _username;

        }

        public static void setUserName(string username)
        {
            _username = username;
        }

        public static string getUserRole()
        {
              return _userRole;
            
        }
        public static void setUserRole(string role)
        {
             _userRole = role;

        }

        public static void setUserPassword(string password)
        {
            _password = password;

        }
        public static string getUserPassword()
        {
            return _password;

        }
        public static void clear()
        {
            _username = null;
            _fullname = null;
            _userRole = null;
            _status = null;
        }
    }
}
