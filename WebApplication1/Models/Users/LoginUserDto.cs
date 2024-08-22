using Microsoft.Build.Framework;

namespace OFlow_Api.Models.Users
{
    public class LoginUserDto
    {
      

            [Required]
            public string Password { get; set; }

            [Required]
            public string Email { get; set; }
        
    }
}
