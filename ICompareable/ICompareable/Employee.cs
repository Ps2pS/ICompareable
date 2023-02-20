using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompareable
{
   public class Employee : IComparable<Employee>
    {
        // Employee data members

        public int EmpId;
        public string EmpName;
        public int EmpAge;


        // Creating Constructor for employee
        public Employee(int EmpId, string EmpName, int EmpAge)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }


        // Using compare to method to compare employee ages
        public int CompareTo(Employee other)
        {
            if (this.EmpAge < other.EmpAge)
            {
                return 1;
            }
            else if (this.EmpAge > other.EmpAge)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
 