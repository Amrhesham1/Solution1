using System;
using System.Collections.Generic;

namespace Oflow_app_Server.Data
{
    public partial class Status1
    {
        public Status1()
        {
            Products1s = new HashSet<Products1>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Products1> Products1s { get; set; }
    }
}
