using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class AccesToVentilation
    {
        public AccesToVentilation()
        {
            Kitchen = new HashSet<Kitchen>();
            Toilet = new HashSet<Toilet>();
        }

        public int AccesToVentilationId { get; set; }
        public string AccesToVentilation1 { get; set; }

        public virtual ICollection<Kitchen> Kitchen { get; set; }
        public virtual ICollection<Toilet> Toilet { get; set; }
    }
}
