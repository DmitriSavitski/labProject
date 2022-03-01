using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class DepartmentsDto
    {
        public int DepartmentIdDto { get; set; }

        public string NameDto { get; set; }

		public int leadersId { get; set; }
		public Leaders LeaderDto { get; set; }

        public List<EmployeesDto> Employee { get; set; } = new List<EmployeesDto>();
    }
}
