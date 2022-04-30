using System;
using satis_core.enums;

namespace satis_db.dtos
{
    public class UserDto : BaseDto
    {
        public UserDto()
        {
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Ranks Rank { get; set; }
    }
}
