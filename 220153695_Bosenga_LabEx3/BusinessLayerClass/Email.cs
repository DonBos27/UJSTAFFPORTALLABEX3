using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerClass
{
    internal class Email
    {
        public Email() { }
        //in this class we generate the email address of the staff member by taking the first letter of the name and the surname in lower case
        public string GenerateEmail(string name, string surname)
        {
            string email = $"{name.ToLower().Substring(0, 1)}{surname.ToLower()}@uj.ac.za";
            return email;
        }
    }
}
