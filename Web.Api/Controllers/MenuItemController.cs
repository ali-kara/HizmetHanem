using Business.Abstract;
using DataAccessLayer.Concrete.EF.MainDB;
using Entities.Abstract;
using Entities.Concrete;
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
    public class MenuItemController : ControllerBase
    {
        IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet("getbyid")]
        public List<MenuItem> Get()
        {
            List<MenuItem> list = new List<MenuItem>();

            list.Add(new MenuItem
            {
                MenuItemId = 1,
                ItemName = "Kahve",
                Price = 22.3,
                Description = "Güzel bir kahve",
                ImageLink = "/assets/images/1"
            });

            list.Add(new MenuItem
            {
                MenuItemId = 2,
                ItemName = "Çay",
                Price = 13.4,
                Description = "Kaçak",
                ImageLink = "/assets/images/1"
            });

            list.Add(new MenuItem
            {
                MenuItemId = 1,
                ItemName = "frappicono",
                Price = 22.3,
                Description = "Güzel bir kahve 2",
                ImageLink = "/assets/images/3"
            });

            _menuItemService.GetByCategory();

            return list;
        }
    }
}
