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
    public class WindowTypeController: BaseController
    {
        public WindowTypeController(IMapper mapper, Context context)
            : base(mapper, context) { }


        [HttpGet]
        [Route("/api/windowTypes")]
        public async Task<IActionResult> GetWindowTypes()
        {
            var windowTypes = await context.WindowType.ToListAsync();
            var transferList = mapper.Map<List<WindowTypeDto>>(windowTypes);
            return new JsonResult(transferList);
        }
    }
}
