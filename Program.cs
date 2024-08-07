using EFCore.Data;
using EFCore.Repositories;
using EFCore.Models;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository(new EmployeeContext());
            WorkstattionRepository workstattion = new WorkstattionRepository(new EmployeeContext());
            DepartmentRepository departmentRepository = new DepartmentRepository(new EmployeeContext());
            ///*Employee employeeToUpdate = new Employee
            //{
            //    Id = 4,
            //    Name = "Sreerag",
            //    Email = "sree678@gmail.com",
            //    Salary = 44000
            //};*/


            //List<Department> departments = departmentRepository.GetAll();
            //departments.ForEach(department => Console.WriteLine(department));
            //Console.WriteLine(repository.Delete(3));
            ///* Console.WriteLine("Successfull Updation of Employee");
            // Console.WriteLine("=====================================================");*/

            //Department department1 = new Department
            //{
            //    Id = 2,
            //    Name = "Law"
            //};



            //var employees = repository.GetAll();
            //employees.ForEach(item => Console.WriteLine(item));

            GetAllDepartments(repository, workstattion, departmentRepository);
        }

        public static void GetAllDepartments(EmployeeRepository repository,WorkstattionRepository workstattion,
            DepartmentRepository department)
        {
            var departments = department.GetAll();
            var employees = repository.GetAll();
            var workstations = workstattion.GetAll();
            foreach(Department dep in departments)
            {
                Console.WriteLine(dep);
                employees.Where(x=>x.);
            }
            
        }
        
            
        
    }
}
