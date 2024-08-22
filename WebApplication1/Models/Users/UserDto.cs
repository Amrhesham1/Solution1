using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace OFlow_Api.Models.Users
{
    public class UserDto : LoginUserDto
    {
        [Microsoft.Build.Framework.Required]
        public string FirstName { get; set; }

        [Microsoft.Build.Framework.Required]
        public string LastName { get; set; }

        [Microsoft.Build.Framework.Required]
        public string Role { get; set; }

        [Microsoft.Build.Framework.Required]
        [EmailAddress]
        public string Email { get; set; }

        [Microsoft.Build.Framework.Required]
        public string Password { get; set; }
    }
}

