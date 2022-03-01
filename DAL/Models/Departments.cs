using System.Collections.Generic;

namespace DAL.Models
{
    public class Departments
    {
        public int DepartmentsId { get; set; }

        public string Name { get; set; }

        public int? LeadersId { get; set; }

        public Leaders Leader { get; set; }

        public List<Employees> Employee { get; set; } = new List<Employees>();
    }
}
