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
    public class ReasonAbcenseVentilationController: BaseController
    {
        public ReasonAbcenseVentilationController(IMapper mapper, Context context)
            : base (mapper, context) { }


        [HttpGet]
        [Route("/api/reasonAbcenseVentilations")]
        public async Task<IActionResult> GetReasonAbcenseVentilations()
        {
            var reasons = await context.ReasonAbcenseVentilation.ToListAsync();

            var transferList = mapper
                .Map<List<ReasonAbcenseVentilationDto>>(reasons);

            return new JsonResult(transferList);
        }
    }
}
