using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class Ventilation
    {
        public int KitchernId { get; set; }
        public int DraftVentilationId { get; set; }
        public byte HasDefects { get; set; }
        public decimal HeightChannel { get; set; }
        public decimal WidthChannel { get; set; }
        public float AnemometrValue { get; set; }

        public virtual DraftVentilation DraftVentilation { get; set; }
        public virtual Kitchen Kitchern { get; set; }
    }
}
