using System;

namespace DAL.Models
{
    public class Protocol
    {
        public int ProtocolId { get; set; }

        public DateTime Date { get; set; }

        public Status Status { get; set; }

        public Users User { get; set; }
    }
}
