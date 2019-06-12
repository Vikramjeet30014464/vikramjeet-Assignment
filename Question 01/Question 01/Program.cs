//Name: Vikramjeet Singh
//Student ID: 30014464
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Loop for Getting userName until correct is received.*/
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine("\nPlease Enter Username (at Least 8 characters):");  //Inform User to Input UserName
                string userName = Console.ReadLine();
                string reply = ValidUsername(userName);
                if (reply == "yes")
                {
                    break;
                }
            }

            /* Loop for Getting password until correct input is received.*/
            while (i > 0)
            {
                Console.WriteLine("\nEnter Your Password (at Least 8 characters):");
                string pass1 = Console.ReadLine();                                      //assign  Input to  pass1 variable.

                Console.WriteLine("Enter password Again to Confirm:");
                string pass2 = Console.ReadLine();                                      //assign  Input   to  pass2 variable.

                string reply2 = ValidPassword(pass1, pass2);

                if (reply2 == "yes")
                {
                    break;
                }
            }


            Console.ReadLine();

        }



        public static string ValidUsername(string userName)
        {
            if (userName.Length >= 8)
            {
                return "yes";
            }
            else
            {
                Console.WriteLine("InValid Length");  // Inform UserName Length is Invalid
                return "no";
            }
        }



        public static string ValidPassword(string pass1, string pass2)
        {

            if (pass1.Length >= 8 && pass1 == pass2)
            {
                Console.WriteLine("\nLogin Sucessfull.");
                return "yes";
            }
            else if (pass1.Length < 8)
            {
                Console.WriteLine("InValid passWord Length");
                return "no";
            }
            else if (pass1 != pass2)
            {
                Console.WriteLine("PassWord Mismatch");
                return "no";
            }

            else
            {
                return "no";
            }

        }
    }
}
