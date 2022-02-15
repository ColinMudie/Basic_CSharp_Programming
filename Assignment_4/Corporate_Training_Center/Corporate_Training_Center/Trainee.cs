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

        }

        public float CalculateScore(out float percentage, out char grade, out string message, bool isRetest = false)
        {
            percentage = 0;
            grade = 'A';
            message = "good job!";
            return 0;
        }
    }
}
