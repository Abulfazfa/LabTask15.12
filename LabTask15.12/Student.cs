using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabTask15._12
{
    internal class Student 
    {
        public  int No { get; set; }
        public string FullName { get; set; }
        public Dictionary<string, int> Exams { get; set; }

        public List<Student> studentList = new List<Student>();
        
        public Student()
        {
            Exams = new Dictionary<string, int>();
        }
        

        public void AddExam(int no, string name, int point)
        {
            Exams.Add(name, point);
        }

        public void GetExamResult(int no, string name)
        {
            foreach (var student in studentList)
            {
                if (no == student.No)
                {
                    foreach (var exam in Exams)
                    {
                        if (name == exam.Key)
                        {
                            Console.WriteLine(exam.Value);
                            break;
                        }
                    }
                }
            }
            
        }
 
        public double GetExamAvg(int no)
        {
            foreach (var item in studentList)
            {
                if (no == item.No)
                {
                  return Exams.Average(a => a.Value);
                }
            }
            return -1;
           
        }

        public void GetExamsResults(int no)
        {
            foreach (var student in studentList)
            {
                if (no == student.No)
                {
                    foreach (var exam in Exams)
                    {
                        Console.WriteLine(exam);
                        break;
                    }
                }
            }
        }

        public Dictionary<string, int> RemoveExam(int no, string name) 
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var student in studentList)
            {
                if (no == student.No)
                {
                    foreach (var exam in Exams)
                    {
                        if (name != exam.Key)
                        {
                            result.Add(exam.Key, exam.Value);
                        }
                    }
                }
            }
            return null;


        }

    
    }
}
