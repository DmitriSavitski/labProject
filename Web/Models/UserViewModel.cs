﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class UserViewModel
    {
        public int UsedId { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public int EmployeeId { get; set; }
    }
}
