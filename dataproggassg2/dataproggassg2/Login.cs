using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataproggassg2
{
    internal class Login
    {
        public void login()
        {
            Console.WriteLine("Enter your EmailId");
            string Emailid = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string Password = Console.ReadLine();
            Console.WriteLine("Login Succesfull");
            Console.WriteLine("Have you paid your full course fees ?");
            Console.WriteLine("\nEnter '1' for yes and '0' for no");
            int option= int.Parse(Console.ReadLine());
            if(option == 1)
            {
                Console.WriteLine("New Announcement\n");
                Console.WriteLine("\nData Programming Assignment 2 due today");

            }
            else if(option == 0)
            {
                Console.WriteLine("Please pay your full fees to access this feature");
            }
            else {
                Console.WriteLine("Enter a valid option");
            }







        }
    }
}
