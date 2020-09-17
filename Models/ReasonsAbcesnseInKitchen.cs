using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class ReasonsAbcesnseInKitchen
    {
        public int KithcenId { get; set; }
        public int ReasonAbcenseVentilationId { get; set; }

        public virtual Kitchen Kithcen { get; set; }
        public virtual ReasonAbcenseVentilation ReasonAbcenseVentilation { get; set; }
    }
}
