using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Data;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Repositories
{
    internal class WorkstattionRepository
    {
        private readonly EmployeeContext _workstation;
        public WorkstattionRepository(EmployeeContext workstation)
        {
            _workstation = workstation;
        }

        public List<Workstattion> GetAll()
        {
            return _workstation.workstattions.ToList();
        }

        public void AddWorkStation(Workstattion workstattion)
        {
            _workstation.Add(workstattion);
            _workstation.SaveChanges();
        }

        public void Update(Workstattion workstattion)
        {
            _workstation.Update(workstattion);
            _workstation.SaveChanges();

        }
        public string Delete(int id) {

            var workstattionToDelete = _workstation.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (workstattionToDelete != null)
            {

                _workstation.Remove(workstattionToDelete);
                _workstation.SaveChanges();
                return $"Workstation record Deleted Successfully";
            }
            else
            {
                return $"Workstation doesn't exist";
            }
        }
    }
}
