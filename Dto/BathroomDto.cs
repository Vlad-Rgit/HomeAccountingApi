using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccountingApi.Dto
{
    public class BathroomDto
    {
        public int BathroomId { get; set; }
        public BathroomTypeDto BathroomType { get; set; }
    }
}
