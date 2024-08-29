using System;
using System.Collections.Generic;

namespace Oflow_app_Server.Data
{
    public partial class Category1
    {
        public Category1()
        {
            Products1s = new HashSet<Products1>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Products1> Products1s { get; set; }
    }
}
