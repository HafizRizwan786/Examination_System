using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_End.BAL
{
    class Student
    {
        private int ID {
            get { return ID; }
            set { ID = value; }
        }
        private string Name { get; set; }
        private string Email { get; set; }
        private int CID { get; set; }
        public Student(int id,string name,string email,int cid)
        {
            ID = id;
            Name = name;
            Email = email;
            CID = cid;
        }
    }
}
