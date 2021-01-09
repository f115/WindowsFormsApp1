using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace MysecondFormsApp1
{
    public static class Session
    {
        public static User User { get; set; }

        

        public static Dashboard Dashboard { get; set; }

        public static Adminpanel AdminPanel { get; set; }

        public static UsersList UserListForm { get; set; }

        public static Loglistform Loglistform { get; set; }

        public static  MainForm1 MainForm1 { get; internal set; }
        public static string Code { get; internal set; }
    }
}