using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades 
{
    class GradeBook 
    {
        public string number;
        List<float> grades = new List<float>();
        public void AddGrade(float grade) 
        {
            Console.Write("Enter grade: ");
            number = Console.ReadLine();

            grades.Add(grade);
            grades.Add(float.Parse(number));
            grades.Add(232f);
            foreach (var item in grades) {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
