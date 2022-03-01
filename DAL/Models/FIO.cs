using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class FIO
    {

        public int FIOId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }
    }
}
