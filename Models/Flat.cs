using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class Flat
    {
        public int FlatId { get; set; }
        public int UserId { get; set; }
        public int HomeId { get; set; }
        public int Entrance { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public int Post { get; set; }
        public byte HasAccess { get; set; }
        public DateTime DateCreated { get; set; }
        public byte[] Signature { get; set; }

        public virtual Home Home { get; set; }
        public virtual User User { get; set; }
        public virtual Bathroom Bathroom { get; set; }
        public virtual Kitchen Kitchen { get; set; }
    }
}
