using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Rest.Icons
{
    public class IconController : ControllerBase
    {
        [HttpGet]
        [Route("icons/favicon")]
        public IActionResult GetFavicon()
        {
            return Content(Official.Icons.Generated.Favicon, "image/svg+xml; charset=utf-8"); 
        }
    }
}
