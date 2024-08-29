using System;
using System.Collections.Generic;

namespace Oflow_app_Server.Data
{
    public partial class Author
    {
        public int Id { get; set; }
        public string? FistName { get; set; }
        public string? LastName { get; set; }
        public string? Bio { get; set; }
    }
}
