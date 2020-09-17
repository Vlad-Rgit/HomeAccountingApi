using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class ReasonAbcenseToilet
    {
        public ReasonAbcenseToilet()
        {
            ReasonAbcenseInToilet = new HashSet<ReasonAbcenseInToilet>();
        }

        public int ReasonAbcenseToiletId { get; set; }
        public string ReasonAbcenseToilet1 { get; set; }

        public virtual ICollection<ReasonAbcenseInToilet> ReasonAbcenseInToilet { get; set; }
    }
}
