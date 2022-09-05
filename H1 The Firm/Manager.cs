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
            string result =  "First name: " + firstName + '\n';
            result += "Last name: " + lastName + '\n';
            result += "CPR-number (vildt nok at vi bare skriver folks CPR-numre ud i en ToString()): " + cprNumber + '\n';
            result += "Phonenumber: " + phoneNumber;
            return result;
        }
    }
}