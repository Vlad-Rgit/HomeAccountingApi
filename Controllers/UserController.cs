using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Net.Mime;
using AutoMapper;
using HomeAccountingApi.Models;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using HomeAccountingApi.Dto;
using Microsoft.AspNetCore.Identity;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Isopoh.Cryptography.Argon2;

namespace HomeAccountingApi.Controllers {

    public class UserController: BaseController
    {
        public UserController(IMapper mapper, Context context)
            : base (mapper, context) { }

        [HttpGet]
        [Route("/api/users")]
        public IActionResult GetUsers()
        {
            var users = context.User.ToList();
            var transferList = mapper.Map<List<UserDto>>(users);
            return new JsonResult(transferList);
        }

        [HttpGet]
        [Route("/api/login")]
        public async Task<IActionResult> LoginUser()
        {


            
                return StatusCode(404);
            
      
        }

        [HttpPost]
        [Route("/api/register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);

            user.Password = Argon2.Hash(user.Password);

            context.User.Add(user);

            try
            {
                await context.SaveChangesAsync();
                return StatusCode(200);
            }
            catch(DbUpdateException ex)
            {
                return new JsonResult(ex);
            }

        }
    }

}