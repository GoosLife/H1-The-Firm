using System;
using H1_The_Firm.Employees;

namespace H1_The_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager("Steve", "Irvin", "111111-1111", "25348920");

            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}