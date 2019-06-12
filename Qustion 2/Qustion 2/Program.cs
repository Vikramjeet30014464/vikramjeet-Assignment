// Name: Vikramjeet singh
//Qustion: 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qustion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("**************Welcome To Holiday's Park Employee Payroll System**************\n\n");  
            Console.Write("Please enter the employee's Full name: ");
            string full_Name = Console.ReadLine();
            Console.Write($"Please enter tax rate: ");
            double tax = double.Parse(Console.ReadLine());
            Console.Write($"Please enter Gross annual income: ");
            double gross = double.Parse(Console.ReadLine());
            Employee p1 = new Employee(full_Name, tax, gross);

            //accessing person 1 Employee class object  
            Console.WriteLine($"Name: {p1.Full_Name}\nTax: {p1.Tax}%\nGross Salary: {p1.Gross}\nNet Salary: {p1.Calculate_Net_Income()}");
            Console.ReadLine();

        }
    }

    class Employee
    {
        /*variables;*/
        private string full_Name;
        private double tax_rate;
        private double gross;

        /*Getters and Setters*/
        public string Full_Name { get { return full_Name; } set { full_Name = value; } }
        public double Tax { get { return tax_rate; } set { tax_rate = value; } }
        public double Gross { get { return gross; } set { gross = value; } }

        /*Constructors*/
        public Employee()
        {
            Console.WriteLine("Employee Record created");
        }


        public Employee(string _full_Name, double _Tax_rate, double _Gross)
        {
            full_Name = _full_Name;
            Tax = _Tax_rate;
            Gross = _Gross;

        }

        /*Method */
        public double Calculate_Net_Income()
        {
            return Gross * (1 - Tax / 100);
        }
    }
}
 
 
     