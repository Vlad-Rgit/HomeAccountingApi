using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class User
    {
        public User()
        {
            Flat = new HashSet<Flat>();
        }

        public int UserId { get; set; }
        public string Fio { get; set; }
        public byte[] Photo { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        public virtual ICollection<Flat> Flat { get; set; }
    }
}
