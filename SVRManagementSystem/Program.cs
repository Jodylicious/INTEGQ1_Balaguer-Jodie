using System;
using System.Collections.Generic;
using SVRMS.BL;

namespace SVRManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "admin";
            string password = "1234";

            Console.WriteLine("Student Violation Record Management System  <press ENTER to continue.>");
            Console.ReadKey();

                Console.Write("Enter username: ");
                username = Console.ReadLine();
                Console.Write("Enter password: ");
                 password = Console.ReadLine();
            
            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("\nLogin Successfully.\n");
                ManageStudent.Homepage();
            }
            else
            {
                Console.WriteLine("Sorry invalid input. Try again.");
                Environment.Exit(0);
            }

        }

       
       

    }
}
