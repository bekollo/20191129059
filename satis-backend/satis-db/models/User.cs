using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using satis_core.enums;

namespace satis_db.models
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public User()
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
