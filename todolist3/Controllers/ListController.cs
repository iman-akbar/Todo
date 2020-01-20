using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todolist3.Services;

namespace todolist3.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly  Services.ListServices _services;

        public ListController(ListServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddLIstItems")]
        public ActionResult<Models.ListItems> AddListItems(Models.ListItems items)
        {
            var listitems = _services.AddListItems(items);

            if (listitems == null)
            {
                return NotFound();
            }
            return listitems;
        }
        [HttpGet]
        [Route("GetListItems")]
        public ActionResult<Dictionary<string, Models.ListItems>> GetListItems()
        {
            var listitems = _services.GetListItems();
            if (listitems.Count == 0)
            {
                return NotFound();
            }
            return listitems;
        }
    }
}