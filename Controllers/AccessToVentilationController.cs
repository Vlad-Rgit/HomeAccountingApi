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
    public class AccessToVentilationController: BaseController
    {
        public AccessToVentilationController(IMapper mapper, Context context) 
            : base (mapper, context) { }

        [HttpGet]
        [Route("/api/accessToVentilations")]
        public async Task<IActionResult> GetAccessToVentialtions()
        {
            var accessToVentilations = await context.AccesToVentilation
                    .ToListAsync();

            var transferList = mapper
                .Map<List<AccesToVentilationDto>>(accessToVentilations);

            return new JsonResult(transferList);
        }
    }
}
