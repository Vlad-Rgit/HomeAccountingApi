using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class Bath
    {
        public int BathroomId { get; set; }
        public int? DraftVentilationId { get; set; }
        public int? AccessToVentilationId { get; set; }
        public byte HasChannel { get; set; }
        public decimal? WidthChannel { get; set; }
        public decimal? HeightChannel { get; set; }
        public float? AnemonetrValue { get; set; }
        public byte[] Photo { get; set; }

        public virtual AccesToVentilation AccessToVentilation { get; set; }
        public virtual Bathroom Bathroom { get; set; }
        public virtual DraftVentilation DraftVentilation { get; set; }
    }
}
