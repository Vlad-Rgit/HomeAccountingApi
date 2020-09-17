using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class Redevelopment
    {
        public Redevelopment()
        {
            Kitchen = new HashSet<Kitchen>();
        }

        public int RedevelopmentId { get; set; }
        public string Redevelopment1 { get; set; }

        public virtual ICollection<Kitchen> Kitchen { get; set; }
    }
}
