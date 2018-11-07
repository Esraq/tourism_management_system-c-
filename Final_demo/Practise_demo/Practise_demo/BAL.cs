using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_demo
{
    class BAL
    {
        DAL f = new DAL();
        private string email;
        private string password;

        public string EEmail
        {
            set { this.email = value; }
            get { return this.email; }

        }
        public string PPassword
        {
            set { this.password = value; }
            get { return this.password; }

        }
        public void llogin()
        {
            string e1 = EEmail;
            string p1 = PPassword;
            f.userlog(e1,p1);


        }
    }
}
