using Microsoft.AspNetCore.Mvc;
using System;

namespace Silvester.Pathfinder.Api.Controllers
{
    public class CharactersController : ControllerBase
    {
        [HttpGet("/characters/{characterId}")]
        public IActionResult GetCharacter(Guid id)
        {
            return Ok(id);
        }

        [HttpGet("/hello/{who}")]
        public IActionResult Hello(string who)
        {
            return Ok("Hello " + who);
        }
    }
}
