using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using HomeAccountingApi.Models;

namespace HomeAccountingApi.Controllers
{
    public class BaseController: Controller
    {
        protected IMapper mapper;
        protected Context context;

        public BaseController(IMapper mapper, Context context){
            (this.mapper, this.context) = (mapper, context);
        }
        
    }
}