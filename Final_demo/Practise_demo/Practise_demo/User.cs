using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_demo
{
    class User
    {
        private string name;
        private string email;
        private string password;
        DB d = new DB();
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }

        }
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
        public void insert()
        {

            string n = Name;
            string e = Email;
            string p = Password;

            d.insert_db(n, e, p);
        }
    }
}
