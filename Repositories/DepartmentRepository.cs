using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Data;
using EFCore.Models;

namespace EFCore.Repositories
{
    internal class DepartmentRepository
    {
        private readonly EmployeeContext _context;
        public DepartmentRepository(EmployeeContext context)
        {
            _context = context;
        }

        public List<Department> GetAll()
        {
            return _context.departments.ToList();
        }

        public void Add(Department department)
        {
            _context.departments.Add(department);
            _context.SaveChanges();
        }

        public void Update(Department department)
        {

            _context.departments.Update(department);
            _context.SaveChanges();
        }

        public string Delete(int id)
        {

            var departmentToDelete = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (departmentToDelete != null)
            {

                _context.Remove(departmentToDelete);
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
