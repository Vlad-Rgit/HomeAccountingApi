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
    public class RedevelopmentController: BaseController
    {
        public RedevelopmentController(IMapper mapper, Context context)
            : base(mapper, context) { }

        [HttpGet]
        [Route("/api/redevelopments")]
        public async Task<ActionResult> GetRedevelopments()
        {
            var redevelopments = await context.Redevelopment.ToListAsync();
            var transferList = mapper
                .Map<List<RedevelopmentDto>>(redevelopments);
            return new JsonResult(transferList);
        }
    }
}
