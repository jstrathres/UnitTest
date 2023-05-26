using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUnitTest
{
    public class GradeCalculator
    {
        public string GetGradeCalculator(int percentage)
        {
            if(percentage >= 90 & percentage <=100)
            {
                return "A";
            }
            else if (percentage >= 80 & percentage < 90)
            {
                return "B!";
            }
            else if (percentage >= 70 & percentage < 80)
            {
                return "C!";
            }
            else if (percentage >= 60 & percentage < 70)
            {
                return "D";
            }
            else if (percentage >= 0 & percentage < 60)
            {
                return "E";
            }
            else
            {
                return "Invalid";
            }
        }
    }
}
