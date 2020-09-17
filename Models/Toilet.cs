using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class Toilet
    {
        public Toilet()
        {
            ReasonAbcenseInToilet = new HashSet<ReasonAbcenseInToilet>();
        }

        public int BathroomId { get; set; }
        public byte HasChannel { get; set; }
        public int? AccesToVentilationId { get; set; }
        public int? DraftVentilationId { get; set; }
        public decimal? WidthChannle { get; set; }
        public decimal? HeightChannel { get; set; }
        public byte[] Photo { get; set; }

        public virtual AccesToVentilation AccesToVentilation { get; set; }
        public virtual DraftVentilation DraftVentilation { get; set; }
        public virtual ICollection<ReasonAbcenseInToilet> ReasonAbcenseInToilet { get; set; }
    }
}
