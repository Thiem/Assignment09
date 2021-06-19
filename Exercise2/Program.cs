using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student management = new Student();
            string confirmContinue;
            int choice = 0;
            Console.WriteLine("=====Student Management Program=====");
            do
            {
                try
                {
                    Console.WriteLine("Enter student's roll number (10 characters) : ");
                    string rollNumber = Console.ReadLine();
                    if (rollNumber.Length != 10)
                    {
                        throw new ArgumentException("Student RollNumer must have exactly 10 characters!");
                    }
                    Console.Write("Enter student's name: ");
                    string studentName = Console.ReadLine();
                    bool addSuccess = management.AcceptDetail(rollNumber, studentName);
                    if (addSuccess)
                    {
                        Console.Write("Do you want to add more records? [Y/N] : ");
                    }
                    else
                    {
                        Console.WriteLine("Do you want to add another records ? [Y/N] : ");
                    }
                    confirmContinue = Console.ReadLine();
                    if (!confirmContinue.ToUpper().Equals("Y"))
                    {
                        break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
            management.DisplayDetail();
            do
            {
                try
                {
                    DisplayMenu();
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter roll number of the student : ");
                        string removingRollNumber = Console.ReadLine();
                        bool removeSuccess = management.Remove(removingRollNumber);
                        if (removeSuccess)
                        {
                            Console.WriteLine("-----After Removing-----");
                            management.DisplayDetail();
                        }
                        else
                        {
                            Console.WriteLine("Remove failed!. Cannot find the student whose rollNumber is : " + removingRollNumber);
                        }
                        break;
                    case 2:
                        management.RemoveAll();
                        Console.WriteLine("=====After removing All=====");
                        management.DisplayDetail();
                        break;
                    case 3:
                        Console.Write("Enter student Roll Number: ");
                        string searchRollNumber = Console.ReadLine();
                        bool find = management.Search(searchRollNumber);
                        if (!find)
                        {
                            Console.WriteLine("Cannot find the student whose roll number is : " + searchRollNumber);
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose again!");
                        break;
                }
            } while (choice != 4);

            Console.WriteLine("Program ENDED!");
            Console.ReadKey();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Select one of the following options: ");
            Console.WriteLine("1. Remove");
            Console.WriteLine("2. Remove All");
            Console.WriteLine("3. Search");
            Console.WriteLine("4. Exit");
        }
    }
}
