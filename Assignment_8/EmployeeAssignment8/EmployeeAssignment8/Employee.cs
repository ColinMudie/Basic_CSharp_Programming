using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment8
{
    public class Employee
    {
        public DateTime DateOfBirth { get; set; }
        public string[] Dependents { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool Gender { get; set; }
        public short NumberOfDependents { get; set; }
        private static int nextEmployeeNumber;
        
        static Employee()
        {
            nextEmployeeNumber = 0;
        }

        public Employee()
        {
            this.EmployeeId = ++nextEmployeeNumber;
            this.Dependents = new string[3];
        }

        public Employee(out int employeeId, string employeeName, DateTime dateOfBirth, bool gender) :this()
        {
            this.EmployeeName = employeeName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            employeeId = this.EmployeeId;
        }

        public Employee(out int employeeId, string employeeName, DateTime dateOfBirth, bool gender, ref short numberOfDependents, params string[] dependents) :this(out employeeId, employeeName, dateOfBirth, gender)
        {
            if (numberOfDependents < 0)
            {
                numberOfDependents = 0;
            }
            else if (numberOfDependents > 3)
            {
                numberOfDependents = 3;
            }
            if (numberOfDependents > dependents.Length)
            {
                numberOfDependents = Convert.ToInt16(dependents.Length);
            }
            this.NumberOfDependents = numberOfDependents;
            this.Dependents = dependents;
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
