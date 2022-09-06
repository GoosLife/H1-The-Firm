using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_Firm.Employees
{
    internal class Manager : Employee
    {
        protected string phoneNumber;

        public Manager(string firstName, string lastName, string cprNumber, string phoneNumber) : base(firstName, lastName, cprNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            string result =  base.ToString();
                   result += "\nPhonenumber: " + phoneNumber;

            return result;
        }
    }
}