using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class ReasonAbcenseVentilation
    {
        public ReasonAbcenseVentilation()
        {
            ReasonsAbcesnseInKitchen = new HashSet<ReasonsAbcesnseInKitchen>();
        }

        public int ReasonAbcenseVentilationId { get; set; }
        public string ReasonAbcenseVentilation1 { get; set; }

        public virtual ICollection<ReasonsAbcesnseInKitchen> ReasonsAbcesnseInKitchen { get; set; }
    }
}
