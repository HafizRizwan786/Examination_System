using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_End.BAL
{
    class Teacher
    {
        private int TID { get; set; }
        private string Fname { get; set; }
        private string Femail { get; set; }
        private string Fpass { get; set; }
        private string Ftype { get; set; }
        public Teacher(int id,string name,string email,string type,string pass)
        {
            TID = id;
            Fname = name;
            Femail = email;
            Ftype = type;
            Fpass = pass;
        }
    }
}
