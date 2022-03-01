using System.Collections.Generic;

namespace DAL.Models
{
    public class Users
    {

        public int UsersId { get; set; }

        public Employees Employee { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
        public string EmailPassword { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public List<Protocol> Protocols { get; set; } = new List<Protocol>();

        public FIO FIO { get; set; }
    }
}
