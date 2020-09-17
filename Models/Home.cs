using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class Home
    {
        public Home()
        {
            Flat = new HashSet<Flat>();
        }

        public int HomeId { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Flat> Flat { get; set; }
    }
}
