using System;
namespace satis_core.dtos
{
    public class AuthenticationDto
    {
        public AuthenticationDto()
        {
        }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
