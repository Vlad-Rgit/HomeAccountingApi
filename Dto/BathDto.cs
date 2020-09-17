using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccountingApi.Dto
{
    public class BathDto
    {
        public int BathroomId { get; set; }
        public byte HasChannel { get; set; }
        public decimal? WidthChannel { get; set; }
        public decimal? HeightChannel { get; set; }
        public float? AnemonetrValue { get; set; }

        public AccesToVentilationDto AccesToVentilation { get; set; }
        public DraftVentilationDto DraftVentilation { get; set; }
    }
}
