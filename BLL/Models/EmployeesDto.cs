using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class EmployeesDto
    {
        public int EmployeeIdDto { get; set; }

        public string EmailDto { get; set; }

		public int fioId { get; set; }
		public FIO FIODto { get; set; }

		public int positionId { get; set; }
		public Position PositionDto { get; set; }

		public int nationalityId { get; set; }
		public Nationality NationalityDto { get; set; }

		public int departmentId { get; set; }
		public Departments DepartmentDto { get; set; }
    }
}
