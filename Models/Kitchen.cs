using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class Kitchen
    {
        public Kitchen()
        {
            ReasonsAbcesnseInKitchen = new HashSet<ReasonsAbcesnseInKitchen>();
        }

        public int FlatId { get; set; }
        public int WindowTypeId { get; set; }
        public int AccesToVentilationId { get; set; }
        public int RedevelopmentId { get; set; }
        public byte HasSupplyDevice { get; set; }
        public byte HasChannel { get; set; }
        public byte[] Photo { get; set; }

        public virtual AccesToVentilation AccesToVentilation { get; set; }
        public virtual Flat Flat { get; set; }
        public virtual Redevelopment Redevelopment { get; set; }
        public virtual WindowType WindowType { get; set; }
        public virtual Ventilation Ventilation { get; set; }
        public virtual ICollection<ReasonsAbcesnseInKitchen> ReasonsAbcesnseInKitchen { get; set; }
    }
}
