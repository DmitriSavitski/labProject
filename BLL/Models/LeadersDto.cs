using DAL.Models;

namespace BLL.Models
{
    public class LeadersDto
    {
        public int LeaderIdDto { get; set; }

        public Employees EmployeeDto { get; set; }

        public Departments DepartmentsDto { get; set; }

        public int EmployeesId { get; set; }
    }
}
