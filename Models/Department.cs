using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Employee> employees { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}\n" +
                $"Name : {Name}\n";
        }

    }

    
}
