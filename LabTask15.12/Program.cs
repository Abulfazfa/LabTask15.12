using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace LabTask15._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please sellect a digit which it contain between 0 and 6;");
            Menu(Convert.ToInt32(Console.ReadLine()));

        }

        public static void Menu(int num)
        {
            Student student = new Student();
            student.studentList.Add(student);
            switch (num)
            {
                case 1:
                    Console.WriteLine("Please enter student's fullname");
                    student.FullName = Console.ReadLine();       
                    break;
                case 2:
                    Console.WriteLine("Please enter student's number, fullname and point");
                    int no = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    int point = Convert.ToInt32(Console.ReadLine());
                    student.AddExam(no, name, point);
                    break ;
                case 3:
                    Console.WriteLine("Please enter student's number and fullname");
                    student.GetExamResult(student.No, student.FullName);
                    break ;
                case 4:
                    Console.WriteLine("Please enter student's number");
                    student.GetExamsResults(student.No);
                    break;
                case 5:
                    Console.WriteLine("Please enter student's number");
                    Console.WriteLine(student.GetExamAvg(student.No));
                    break;
                case 6:
                    Console.WriteLine("Please enter student's number and fullname");
                    Console.WriteLine(student.RemoveExam(student.No, student.FullName)); 
                    break;
                case 0:
                    
                    break;             
                default:          
                    break;
            }
        }
    }
}
