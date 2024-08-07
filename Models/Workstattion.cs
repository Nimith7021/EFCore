using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Workstattion
    {
        [Key]
        public int WorkStationId { get; set; }

        public string WSCode { get; set; }

        public Employee Employee { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; } = 0;

        public override string ToString()
        {
            return $"WorkstattionID : {WorkStationId}\n" +
                $"WSCode : {WSCode}\n";
        }
    }
}
