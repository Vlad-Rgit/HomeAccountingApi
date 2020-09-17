using HomeAccountingApi.Models;
using Isopoh.Cryptography.Argon2;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccountingApi.Middlewares
{
    public class AuthMiddleware
    {
        private RequestDelegate next;

        public AuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }


        public async Task InvokeAsync(HttpContext httpContext, Context dbContext)
        {
            
            if(httpContext.Request.Path == "/api/register")
            {
                await next.Invoke(httpContext);
            }
            else
            {
                string[] values = httpContext.Request.Headers["Authorization"]
                    .ToString()
                    .Split(' ');

               if(values[0] == "Basic")
               {
                    byte[] bytes = Convert.FromBase64String(values[1]);

                    string login_password = Encoding.UTF8.GetString(bytes);

                    int divider = login_password.IndexOf(':');

                    string login = login_password.Substring(0, divider);
                    string password = login_password.Substring(divider + 1);
                
                    var user = await dbContext.User.FirstOrDefaultAsync(
                        u => u.Login == login);


                    if (user == null ||
                        !Argon2.Verify(user.Password, password))
                    {
                        httpContext.Response.StatusCode = 401;

                        /*await httpContext.Response
                            .WriteAsync("Uncorrect password or login");*/
                    }
                    else if (httpContext.Request.Path == "/api/login")
                    {
                        httpContext.Response.StatusCode = 200;
                        await httpContext.Response.WriteAsync("{" +
                            "\"status\" : \"ok\"}");
                    }
                    else
                    {
                        await next.Invoke(httpContext);
                    }
               } 
               else
               {
                    await httpContext.Response.WriteAsync("Only basic auth is supported");
               }

            }

        }




    }
}
