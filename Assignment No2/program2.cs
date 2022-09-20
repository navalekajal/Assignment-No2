using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_No2
{
    internal class program2
    {
        static void Main(string[] args)
        {
            int DA, HRA, gross;
            Console.WriteLine("Enter a Basic salary");
            int salary = Convert.ToInt32(Console.ReadLine());


            if (salary <= 10000)
            {
                DA = (salary * 80) / 100;
                HRA = (salary * 20) / 100;
                gross = salary + DA + HRA;
                Console.WriteLine($"Gross salary is {gross}");
            }

            else if (salary <= 20000)
            {
                DA = (salary * 90) / 100;
                HRA = (salary * 35) / 100;
                gross = salary + DA + HRA;
                Console.WriteLine($"Gross salary is {gross}");

            }
            else 
            {
                DA = (salary * 95) / 100;
                HRA = (salary * 40) / 100;
                gross = salary + DA + HRA;
                Console.WriteLine($"Gross salary is {gross}");

            }
        }
    }
}

