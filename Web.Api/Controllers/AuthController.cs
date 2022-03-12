using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            List<string> list = new();

            for (int i = 0; i < 5; i++)
            {
                list.Add(DateTime.Now.ToLongTimeString());
            }

            return list;
        }

        [HttpGet("GetAll")]
        public List<string> GetAll(int id)
        {
            List<string> list = new();

            for (int i = 0; i < 10; i++)
            {
                list.Add(DateTime.Now.ToLongTimeString());
            }

            return list;
        }
    }
}
