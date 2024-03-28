using EntityFrameworkCore.EncryptColumn.Attribute;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDemo2.DAL
{
    [Index(nameof(User.Name), IsUnique = true)]
    [Index(nameof(User.Password))]
    public class User
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be blank!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password cannot be blank")]
        [Encrypted]
        public string Password { get; set; }

        public int UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; } 
    }
}
