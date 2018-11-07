using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_demo
{
    class BL
    {
        DAL d = new DAL();
        private string email;
        private string password;

        public string Email
        {
            set { this.email = value; }
            get { return this.email; }

        }
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }

        }
        public void login()
        {
            string e = Email;
            string p = Password;
            d.log_db(e, p);


        }
    }
}
