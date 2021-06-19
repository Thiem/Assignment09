using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Student
    {
        private Hashtable studentsList = new Hashtable();

        public bool AcceptDetail(string rollNumber, string name)
        {
            if (name != "" && name != null && rollNumber != null)
            {
                studentsList.Add(rollNumber, name);
                return true;
            }
            return false;
        }

        public void DisplayDetail()
        {
            Console.WriteLine("\nDetails of students : ");
            Console.WriteLine("Student's RollNumber\t\tFullName" +
                              "\n--------------------\t\t--------");
            foreach (DictionaryEntry student in studentsList)
            {
                Console.WriteLine($"{student.Key}\t{student.Value}");
            }

            Console.WriteLine("Total number of students : " + studentsList.Count);
        }

        public bool Remove(string rollNumber)
        {
            if (studentsList.ContainsKey(rollNumber))
            {
                studentsList.Remove(rollNumber);
                return true;
            }
            return false;
        }

        public bool RemoveAll()
        {
            if (studentsList.Count > 0)
            {
                studentsList.Clear();
                return true;
            }
            return false;
        }

        public bool Search(string rollNumber)
        {
            if (studentsList.ContainsKey(rollNumber))
            {
                foreach (DictionaryEntry student in studentsList)
                {
                    if (student.Key.Equals(rollNumber))
                    {
                        Console.WriteLine($"{student.Key}\t{student.Value}");
                    }
                }
                return true;
            }
            return false;
        }
    }
}
