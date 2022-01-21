using Microsoft.AspNetCore.Mvc;

namespace Silvester.Pathfinder.Reference.Api.Rest.Icons
{
    public class IconController : ControllerBase
    {
        [HttpGet]
        [Route("icons/favicon")]
        public IActionResult GetFavicon()
        {
            return Content(Reference.Icons.Generated.Favicon, "image/svg+xml; charset=utf-8"); 
        }
    }
}
