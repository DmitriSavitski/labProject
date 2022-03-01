using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class FIODto
    {
        public int FIOIdDto { get; set; }

        public string LastNameDto { get; set; }

        public string FirstNameDto { get; set; }

        public string MiddleNameDto { get; set; }

        public Employees EmployeeDto { get; set; }
    }
}
