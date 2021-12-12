using EasyPush.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPush.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public  UserController (IUserService pUserService)
        {
            this.userService = pUserService;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(this.userService.Get());
        }


    }
}
