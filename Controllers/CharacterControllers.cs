using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System;

namespace dotnet_rpg.Controllers
{

    [ApiController]
    [Route("customeRoute")]

    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        [HttpGet]

        public ActionResult<Character> Get()
        {

            Console.WriteLine(knight.Class);
            return Ok(knight);
        }
    }
}