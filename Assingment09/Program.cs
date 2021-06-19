using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment09
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagement management = new StudentManagement();
            string confirmContinue;
            int choice = 0;
            Console.WriteLine("=====Student Management Program=====");
            do
            {
                Console.Write("Enter student's name: ");
                string studentName = Console.ReadLine();
                bool addSuccess = management.AcceptDetail(studentName);
                if (addSuccess)
                {
                    Console.Write("Do you want to add more names? [Y/N] : ");
                }
                else
                {
                    Console.WriteLine("Add failed!");
                    Console.WriteLine("Do you want to add another name ? [Y/N] : ");
                }
                confirmContinue = Console.ReadLine();
            } while (confirmContinue.ToUpper().Equals("Y"));
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
                        management.Sort();
                        Console.WriteLine("-----After Sorting-----");
                        management.DisplayDetail();
                        break;
                    case 2:
                        Console.Write("Enter name of the student : ");
                        string removingName = Console.ReadLine();
                        bool removeSuccess = management.Remove(removingName);
                        if (removeSuccess)
                        {
                            Console.WriteLine("-----After Removing-----");
                            management.DisplayDetail();
                        }
                        else
                        {
                            Console.WriteLine("Remove failed!. Cannot find the student whose name is : " + removingName);
                        }
                        break;
                    case 3:
                        management.Reverse();
                        Console.WriteLine("-----After Reversing-----");
                        management.DisplayDetail();
                        break;
                    case 4:
                        Console.Write("Enter student name: ");
                        string searchName = Console.ReadLine();
                        bool find = management.Search(searchName);
                        if (!find)
                        {
                            Console.WriteLine("Cannot find the student whose name is : " + searchName);
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose again!");
                        break;
                }
            } while (choice != 5);
            Console.WriteLine("\nProgram ENDED!");
            Console.ReadKey();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Select one of the following options: ");
            Console.WriteLine("1. Sort");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Reverse");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Exit");
        
     }
    }
}
