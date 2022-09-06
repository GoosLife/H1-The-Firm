using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_Firm.Employees
{
    internal abstract class Employee
    {
        protected internal string firstName;
        protected internal string lastName;
        protected internal string cprNumber;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="cprNumber"></param>
        public Employee(string firstName, string lastName, string cprNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cprNumber = cprNumber;
        }

        public override string ToString()
        {
            string result = "First name: " + firstName + '\n';
            result += "Last name: " + lastName + '\n';
            result += "CPR-number: " + cprNumber; // I have concerns about outputting employees' CPR-number like this ???

            return result;
        }
    }
}
