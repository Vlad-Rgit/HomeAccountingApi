using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccountingApi.Dto
{
    public class VentilationDto
    {
        public int KitchernId { get; set; }
        public byte HasDefects { get; set; }
        public decimal HeightChannel { get; set; }
        public decimal WidthChannel { get; set; }
        public float AnemometrValue { get; set; }

        public virtual DraftVentilationDto DraftVentilation { get; set; }
    }
}
