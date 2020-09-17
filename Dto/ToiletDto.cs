using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccountingApi.Dto
{
    public class ToiletDto
    {
        public int BathroomId { get; set; }
        public byte HasChannel { get; set; }
        public decimal? WidthChannle { get; set; }
        public decimal? HeightChannel { get; set; }     

        public virtual AccesToVentilationDto AccesToVentilation { get; set; }
        public virtual DraftVentilationDto DraftVentilation { get; set; }

        public List<ReasonAbcenseToiletDto> ReasonAbcenses { get; set; }
    }
}
