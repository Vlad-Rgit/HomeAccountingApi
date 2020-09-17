using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class ReasonAbcenseInToilet
    {
        public int ToileteId { get; set; }
        public int ReasonAbcenseToilet { get; set; }

        public virtual ReasonAbcenseToilet ReasonAbcenseToiletNavigation { get; set; }
        public virtual Toilet Toilete { get; set; }
    }
}
