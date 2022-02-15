using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporate_Training_Center
{
    public class Trainee
    {
        public string[] FocusArea { get; set; }
        public float[] Marks { get; set; }

        public Trainee()
        {

        }

        public Trainee(string[] p_focusArea, float[] p_marks)
        {
            this.FocusArea = p_focusArea;
            this.Marks = p_marks;
        }

        public float CalculateScore(out float percentage, out char grade, out string message, bool isRetest = false)
        {
            percentage = 0;
            foreach (float mark in this.Marks)
            {
                percentage += mark;
            }
            percentage /= this.Marks.Length;
            if (isRetest)
            {
                percentage -= 10;
            }

            if (percentage >= 85 && percentage <= 100)
            {
                grade = 'A';
            }
            else if (percentage >= 75 && percentage <= 84)
            {
                grade = 'B';
            }
            else if (percentage >= 0 && percentage < 75)
            {
                grade = 'C';
            }
            else 
            {
                grade = 'N';
            }

            if (percentage >= 50 && percentage <= 100)
            {
                message = "Qualified";
            }
            else
            {
                message = "Not Qualified";
            }
            return percentage;
        }
    }
}
