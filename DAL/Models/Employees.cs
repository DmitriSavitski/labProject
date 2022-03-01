namespace DAL.Models
{
    public class Employees
    {
        public int EmployeesId { get; set; }

        public string Email { get; set; }

		public int FIOId { get; set; }
		public FIO FIO { get; set; }

		public int PositionId { get; set; }
		public Position Position { get; set; }

		public int DepartmentsId { get; set; }
		public Departments Department { get; set; }
	}
}
