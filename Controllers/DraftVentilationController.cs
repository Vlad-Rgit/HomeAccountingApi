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
    public class DraftVentilationController: BaseController
    {
        public DraftVentilationController(IMapper mapper, Context context) 
            : base(mapper, context) { }

        [HttpGet]
        [Route("/api/draftVentilation")]
        public async Task<IActionResult> GetDraftVentilations()
        {
            var draftVentilations = await context.DraftVentilation
                .ToListAsync();

            var transferList = mapper
                .Map<List<DraftVentilationDto>>(draftVentilations);

            return new JsonResult(transferList);
        }
    }
}
