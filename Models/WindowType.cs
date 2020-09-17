using System;
using System.Collections.Generic;

namespace HomeAccountingApi.Models
{
    public partial class WindowType
    {
        public WindowType()
        {
            Kitchen = new HashSet<Kitchen>();
        }

        public int WindowTypeId { get; set; }
        public string WindowType1 { get; set; }

        public virtual ICollection<Kitchen> Kitchen { get; set; }
    }
}
