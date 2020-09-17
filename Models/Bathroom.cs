using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class Bathroom
    {
        public int FlatId { get; set; }
        public int BathroomTypeId { get; set; }

        public virtual BathroomType BathroomType { get; set; }
        public virtual Flat Flat { get; set; }
    }
}
