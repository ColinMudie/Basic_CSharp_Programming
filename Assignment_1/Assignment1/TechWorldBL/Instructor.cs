using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechWorldBL
{
    public class Instructor
    {
        public Instructor()
        {

        }

        public Instructor(string p_instructorName, float p_avgFeedback, int p_experience, string[] p_instructorSkill)
        {
            this.AvgFeedback = p_avgFeedback;
            this.Experience = p_experience;
            this.InstructorName = p_instructorName;
            this.InstructorSkill = p_instructorSkill;
        }

        public float AvgFeedback { get; set; }
        public int Experience { get; set; }
        public string InstructorName { get; set; }
        public string[] InstructorSkill { get; set; }

        /// <summary>
        /// This method accepts a technology name as input parameter and
        /// check whether the instructor possesses that skill.
        /// </summary>
        /// <param name="p_technology">technology to check</param>
        /// <returns>boolean result</returns>
        public bool CheckSkill(string p_technology)
        {
            if (!this.ValidateEligibility())
            {
                return false;
            }

            bool result = false;
            foreach(string skill in this.InstructorSkill)
            {
                if (skill.ToLower() == p_technology.ToLower())
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// The method should check the eligibility criteria as given below:
        /// 
        ///     - An instructor with more than 3 years of experience should have an 
        ///         average feedback greater than or equal to 4.5.
        ///         
        ///     - An instructor with less than or equal to 3 years of experience 
        ///         should have an average feedback greater than or equal to 4.
        /// </summary>
        /// <returns>boolean result</returns>
        public bool ValidateEligibility()
        {
            if (this.Experience > 3 && this.AvgFeedback >= 4.5)
            {
                return true;
            }
            else if (this. Experience <= 3 && this.AvgFeedback >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
