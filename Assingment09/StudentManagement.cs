using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment09
{
    class StudentManagement
    {
         
        private ArrayList studentNames = new ArrayList();
        public StudentManagement()
        {

        }

        public bool AcceptDetail(string name)
        {
            if (name != "" && name != null)
            {
                studentNames.Add(name);
                return true;
            }
            return false;
        }
        public void DisplayDetail()
        {
            Console.WriteLine("\nList of students : ");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Total number of students : " + studentNames.Count);
        }
        public bool Remove(string name)
        {
            if (studentNames.Contains(name))
            {
                while (studentNames.Contains(name))
                {
                    studentNames.RemoveAt(studentNames.IndexOf(name));
                }
                return true;
            }

            return false;

        }

        public bool Search(string name)
        {
            if (studentNames.Contains(name))
            {
                Console.WriteLine($"{name} / Index in array list: {studentNames.IndexOf(name)}");
                return true;
            }
            return false;
        }

        public void Sort()
        {
            studentNames.Sort();
        }
        public void Reverse()
        {
            studentNames.Reverse();
        }
    }
}
