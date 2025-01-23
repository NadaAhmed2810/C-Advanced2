using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced2
{
    class EmployeeComparerByName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Name?.CompareTo(y?.Name) ?? (y is null ? 0 : -1);
        }
    }
    internal class Employee:IComparable<Employee>
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id={Id},Name={Name},Salary={Salary}";
        }

 

        public int CompareTo(Employee? other)
        {
           if(other == null) return 1 ;
           return Salary.CompareTo(other.Salary) ;
        }
    }
}
