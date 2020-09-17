using HomeAccountingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccountingApi.Dto
{
    public class KitchenDto
    {
        public int FlatId { get; set; }
        public byte HasSupplyDevice { get; set; }
        public byte HasChannel { get; set; }

        public AccesToVentilationDto AccesToVentilation { get; set; }
        public RedevelopmentDto Redevelopment { get; set; }
        public WindowTypeDto WindowType { get; set; }
        public VentilationDto Ventilation { get; set; }

        public List<ReasonAbcenseVentilationDto> ReasonAbcenses { get; set; }
    }
}
