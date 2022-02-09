using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class GradebookDictionary
    {
        static void Main2(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string,int>();
            string newStudent;

            Console.WriteLine("Enter the details:");

            Console.WriteLine("Student: ");
            string input = Console.ReadLine();
            newStudent = input;

         
            Console.WriteLine("ID: ");
            input = Console.ReadLine();
            int newID = int.Parse(input);
            students.Add(newStudent, newID);

               
                Console.ReadLine();
            }

        }
    }

