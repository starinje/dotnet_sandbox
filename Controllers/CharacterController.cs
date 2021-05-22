using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using dotnet_sandbox.Services.CharacterService;
using System.Threading.Tasks;
using dotnet_sandbox.Models;
using dotnet_sandbox.Dtos.Character;

namespace dotnet_rpg.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            Console.Write("Inside CharacterController constructor...");
            _characterService = characterService;
        }

        [HttpGet("GetAll")]

        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            Console.Write("Inside GetAll method in the controller");

            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
                return Ok(await _characterService.GetCharacterById(id));

        }

        [HttpPost]

        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));

        }

        [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacter(updatedCharacter);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Delete(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);

        }
    }
}