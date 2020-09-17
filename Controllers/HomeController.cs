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
    public class HomeController: BaseController
    {
        public HomeController(IMapper mapper, Context context)
            : base(mapper, context) { }


        [HttpGet]
        [Route("/api/homes")]
        public async Task<IActionResult> GetHomesAsync()
        {
            var homes = await context.Home.ToListAsync();

            var transferList = mapper.Map<List<HomeDto>>(homes);

            return new JsonResult(transferList);
        }

    }
}
