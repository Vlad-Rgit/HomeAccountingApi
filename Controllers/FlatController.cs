using AutoMapper;
using HomeAccountingApi.Dto;
using HomeAccountingApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccountingApi.Controllers
{
    public class FlatController: BaseController
    {
        public FlatController(IMapper mapper, Context context)
            : base(mapper, context) { }

        [HttpGet]
        [Route("/api/flats/{homeId}")]
        public async Task<IActionResult> GetFlatsByHome(int homeId)
        {
            var flats = await context.Flat
                .Where(f => f.HomeId == homeId)
                .Include(f => f.User)
                .Include(f => f.Home)
                .Include(f => f.Kitchen)
                .ToListAsync();

            var transferList = mapper.Map<List<FlatDto>>(flats);

            return new JsonResult(transferList);
        }
    }
}
