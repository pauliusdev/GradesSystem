using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades 
{
    class GradeBook 
    {
        public GradeBook() {
            
        }

        public void AddGrade(float grade) 
        {
            if(grade >= 0 && grade <= 100) {
                grades.Add(grade);
            }
           
        }

        public GradeStatistics ComputeStatistics() {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;
            foreach (float grade in grades) {
                sum += grade;
            }
            if(sum > 0) {
                stats.HighestGrade += sum;
            }
            
            stats.AvarageGrade = sum / grades.Count;
            return stats;
        }
        private List<float> grades = new List<float>();
    }
}
