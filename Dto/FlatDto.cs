using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccountingApi.Dto
{
    public class FlatDto
    {
        public int FlatId { get; set; }
        public int Entrance { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public int Post { get; set; }
        public byte HasAccess { get; set; }
        public DateTime DateCreated { get; set; }
        

        public HomeDto Home { get; set; }
        public UserDto User { get; set; }
        public BathroomDto Bathroom { get; set; }
        public KitchenDto Kitchen { get; set; }
    }
}
