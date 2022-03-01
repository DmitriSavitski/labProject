using System;

namespace BLL.Models
{
    public class ProtocolDto
    {
        public int ProtocolIdDto { get; set; }

        public DateTime DateDto { get; set; }

        public StatusDto StatusDto { get; set; }

        public UsersDto UserDto { get; set; }
    }
}
