using DAL.Models;
using System.Collections.Generic;

namespace BLL.Models
{
    public class UsersDto
    {
        public int UserIdDto { get; set; }

        public Employees EmployeeDto { get; set; }

        public string LoginDto { get; set; }

        public string PasswordDto { get; set; }

        public string EmailDto { get; set; }

        public string EmailPasswordDto { get; set; }

        public Role RoleDto { get; set; }

        public List<Protocol> ProtocolsDto { get; set; } = new List<Protocol>();

        public FIO FIO { get; set; }
    }
}
