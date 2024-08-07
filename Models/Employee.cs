using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Workstattion workstattion { get; set; }
        public double Salary { get; set; }

        [ForeignKey("Department")]

        public int? DepartmentID { get; set; }

        public Department department { get; set; }

        public override string ToString()
        {
            return $"Emp Id : {Id}\n" +
                $"Emp Name : {Name}\n" +
                $"Emp Email : {Email}\n" +
                $"Salary : {Salary}\n";

        }
    }
}
