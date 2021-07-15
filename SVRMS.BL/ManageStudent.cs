using System;
using System.Collections.Generic;

namespace SVRMS.BL
{
    public class ManageStudent
    {
        public static void Homepage()

        {
            ManageStudent manage = new ManageStudent();

            List<string> actions = new List<string>(){ "1. View Student Record\n" +
                              "2. Add Student \n" +
                              "3. Delete student profile \n" + "4. Violation Reports \n" };
            foreach (var choices in actions)
            {
                Console.WriteLine(choices);
            }
            Console.Write("Enter number of choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ManageStudent.viewStudentRecord();
                    break;

                case "2":
                    ManageStudent.addStudentRecord();
                    break;

                case "3":
                    ManageStudent.deleteStudentRecord();
                    break;

                case "4":
                    ManageStudent.violationReports();
                    break;

                default:
                    Console.WriteLine("Invalid. Please try again.");
                    break;
            }
        }
        public static void viewStudentRecord()
        {
            List<string> studentlist = new List<string>() { "\nJodie Balaguer", "Michelle Ozoa", "McDale Organo", "Mark Acorda", "Clark Rayos" };
            foreach (var names in studentlist)
            {
                Console.WriteLine(names);
            }
            Exit();
        }
        

        public static void addStudentRecord()
        {
            Console.Write("Enter Student Number: ");
            var id = Console.ReadLine();
            Console.Write("Enter Student Fullname: ");
            var name = Console.ReadLine();
            Console.WriteLine("\nStudent Number: {0}  \nStudent Name: {1}", id, name);

            List<string> violationlist = new List<string>(){"\nLIST OF VIOLATION: " +
                             "\na. ACADEMIC DISHONESTY ( Cheating, Plagiarism )" +
                             "\nb. ATTENDANCE AND PUNCTUALITY ( Late, Absence, Tardy )" +
                             "\nc. HARRASSMENT ( Bullying, Sexual Harrassment, Fighting)" +
                             "\nd. DAMAGE TO PROPERTY ( Vandalism )\n"};

            foreach (var violate in violationlist)
            {
                Console.WriteLine(violate);
            }
            Console.Write("Enter Student Violation: ");
            var violation = Console.ReadLine();


            switch (violation)
            {
                case "a":
                    Console.WriteLine("Violation: ACADEMIC DISHONESTY"); break;
                case "b":
                    Console.WriteLine("Violation: ATTENDANCE AND PUNCTUALITY"); break;
                case "c":
                    Console.WriteLine("Violation: HARRASSMENT"); break;
                case "d":
                    Console.WriteLine("Violation: DAMAGE TO PROPERTY"); break;
                default:
                    Console.WriteLine("Invalid. Please try again.");
                    addStudentRecord();
                    break;

            }
            Console.Write("\nStudent Violation Succesfully added as of   " + DateTime.Now);
            Exit();
        }

        public static void deleteStudentRecord()
        {
            var students = new List<string>() { "Jodie Balaguer", "Michelle Ozoa", "Dale Organo", "Mark Acorda", "Clark Rayos\n" };
            foreach (var newlist in students)
            {
                Console.WriteLine(newlist);
            }
            Console.Write("Enter Student Name to remove: ");
            var remName = Console.ReadLine();
            Console.WriteLine("\nStudent Profile is successfully removed as of   " + DateTime.Now);

            Exit();
        }

        public static void violationReports()
        {
            string name;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                             REPORTS                               ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n List of Student Violators: \n" +
                "\n1. Jodie Balaguer" + "\n2. Michelle Ozoa" +
               "\n3. Mark Acorda" + "\n4. Clark Rayos\n");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Enter the number to show student's violation: ");
            name = Console.ReadLine();

            if (name == "1")
            {
                Console.WriteLine("Violator: Jodie Balaguer " + "\nViolation: Attendance and Punctuality");
            }
            else if (name == "2")
            {
                Console.WriteLine("Violator: Michelle Ozoa" + "\nViolation: Dishonesty");
            }
            else if (name == "3")
            {
                Console.WriteLine("Violator: Mark Acorda " + "\nViolation: Academic Dishonesty");
            }
            else if (name == "4")
            {
                Console.WriteLine("Violator: Clark Rayos " + "\nViolation: Harrassment");
            }
            else
            {
                Console.WriteLine(" Incorrect input name! Enter Again.\n");
                violationReports();
            }

            Console.Write("\nShow another student violation record? ( y/n )   : ");
            string input = Console.ReadLine();
            if (input.Equals("y"))
            {
            violationReports();
            }
            else if (input.Equals("n"))
            {
                Exit();
            }
            else
            {
                Console.WriteLine("Invalid. ");
            }
        }
        public static void Exit()
        {
            Console.Write("\n Press  'y'  if you want to EXIT. " +
                          "\n Press  'n'  Back to HOMEPAGE. ");
            char choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------");

            if (choice.Equals('y'))
            {
                Console.WriteLine("\n\n\n Logging out...    Note: You can always back in at any time. Thank you.     ");
                Environment.Exit(0);
            }
            else if (choice.Equals('n'))
            {
                Homepage();
            }
            else
            {
                Console.Write(" Invalid. ");
                Environment.Exit(0);
            }
        }
    }
    }

