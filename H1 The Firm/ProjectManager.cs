using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_Firm.Employees
{
    internal class ProjectManager : Manager
    {
        private string email;

        public ProjectManager(string firstName, string lastName, string cprNumber, string phoneNumber, string email) : base(firstName, lastName, cprNumber, phoneNumber)
        {
            this.email = email;
        }

        public override string ToString()
        {
            string result =  base.ToString();
                   result += "\nEmail: " + email;

            return result;
        }
    }
}
