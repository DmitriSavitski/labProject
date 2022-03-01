namespace DAL.Models
{
    public class Leaders
    {
        public int? LeadersId { get; set; }
		
		public Employees Employee { get; set; }

		public Departments Departments { get; set; }

		public int EmployeesId { get; set; }
	}
}
