using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Data;
using EFCore.Models;

namespace EFCore.Repositories
{
    internal class EmployeeRepository
    {
        private readonly EmployeeContext _context;
        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public void Add(Employee employee) { 
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Update(Employee employee) { 
        
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public string Delete(int id) { 
        
            var empToDelete = _context.Employees.Where(x=>x.Id==id).FirstOrDefault();
            if (empToDelete != null) { 
            
                _context.Remove(empToDelete);
                _context.SaveChanges();
                return $"Employee record Deleted Successfully";
            }
            else
            {
                return $"Employee doesn't exist";
            }
        }
    }
}
