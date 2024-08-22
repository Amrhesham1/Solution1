﻿using System.ComponentModel.DataAnnotations;

namespace OFlow_Api.Models.Author
{
    public class AuthorCreateDtocs
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        

        [StringLength(50)]
        public string Bio { get; set; }



    }
}
