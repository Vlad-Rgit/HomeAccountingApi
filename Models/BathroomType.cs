using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class BathroomType
    {
        public BathroomType()
        {
            Bathroom = new HashSet<Bathroom>();
        }

        public int BathroomTypeId { get; set; }
        public string BathroomType1 { get; set; }

        public virtual ICollection<Bathroom> Bathroom { get; set; }
    }
}
