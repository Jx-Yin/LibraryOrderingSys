using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUIST_LibSeatOrdering
{
    public class Student
    {
        public int account { get; set; }
        public string password { get; set; }
        public bool ordered = false;
        public static int count = 0;
        public bool blocked = false;
        public int floor, number;

        public Student ()
        {
        }

        public Student(int account, string password)
        {
            this.account = account;
            this.password = password;
        }

        public Student(int account, string password, bool ordered)
        {
            this.account = account;
            this.password = password;
            this.ordered = ordered;
        }

        public override string ToString()
        {
            return string.Format("account:{0}, password:{1}", account, password);
        }

        public void password_set(string password)
        {
            this.password = password;
        }

    }
}
