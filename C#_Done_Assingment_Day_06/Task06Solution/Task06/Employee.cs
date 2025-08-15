using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    //Problem03
    public struct Employee
    {
        private int EmpId;
        private string Name;
        private decimal Salary;

        public Employee(int empId, string name, decimal salary)
        {
            EmpId = empId;
            Name = name;
            Salary = salary;
        }

        // Getter & Setter
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        // Property
        public int EmployeeId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public decimal EmployeeSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public void DisplayEmpInfo()
        {
            Console.WriteLine($"ID: {EmpId}, Name: {Name}, Salary: {Salary}");
        }
    }

    //--------------------------------------------------------------------
    // Problem06
    public class Employee02
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee02(int empId, string name, decimal salary)
        {
            EmpId = empId;
            Name = name;
            Salary = salary;
        }
        public void DisplayEmp02Info()
        {
            Console.WriteLine($"ID: {EmpId}, Name: {Name}, Salary: {Salary}");
        }
        public override string ToString()
        {
            return $"ID: {EmpId}, Name: {Name}, Salary: {Salary}";
        }
    }


}
