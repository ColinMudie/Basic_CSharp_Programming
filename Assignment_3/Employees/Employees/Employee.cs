using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        public DateTime DateOfBirth { get; set; }
        public string[] Dependents { get; set; } = new string[3];
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool Gender { get; set; }
        public short NumberOfDependents { get; set; }

        private static int nextEmployeeNumber;

        static Employee()
        {
            nextEmployeeNumber = 1000;
        }

        public Employee()
        {
            this.EmployeeId = ++nextEmployeeNumber;
        }

        public Employee(string p_employeeName, DateTime p_dateOfBirth, bool p_gender) :this()
        {
            this.EmployeeName = p_employeeName;
            this.DateOfBirth = p_dateOfBirth;
            this.Gender = p_gender;
        }

        public Employee(string p_employeeName, DateTime p_dateOfBirth, bool p_gender, short p_numberOfDependents) :this(p_employeeName, p_dateOfBirth, p_gender)
        {
            if (p_numberOfDependents < 0)
            {
                this.NumberOfDependents = 0;
            }
            else if (p_numberOfDependents > 3)
            {
                this.NumberOfDependents = 3;
            }
            else
            {
                this.NumberOfDependents = p_numberOfDependents;
            }
        }

        public int AddDependent(string p_dependentName)
        {
            if (this.NumberOfDependents == 3)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < this.Dependents.Length; i++)
                {
                    if (this.Dependents[i] == null)
                    {
                        this.Dependents[i] = p_dependentName;
                        return ++this.NumberOfDependents;
                    }
                }
                return this.NumberOfDependents;
            }
        }

        public bool UpdateDependents(string p_dependentsName, int p_dependentId)
        {
            if (this.Dependents[p_dependentId - 1] != null)
            {
                this.Dependents[p_dependentId - 1] = p_dependentsName;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
