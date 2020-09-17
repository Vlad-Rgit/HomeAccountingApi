using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class DraftVentilation
    {
        public DraftVentilation()
        {
            Toilet = new HashSet<Toilet>();
            Ventilation = new HashSet<Ventilation>();
        }

        public int DraftVentilationId { get; set; }
        public string DraftVentilation1 { get; set; }

        public virtual ICollection<Toilet> Toilet { get; set; }
        public virtual ICollection<Ventilation> Ventilation { get; set; }
    }
}
