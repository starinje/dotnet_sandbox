using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using dotnet_sandbox.Dtos.Character;
using dotnet_sandbox.Models;

namespace dotnet_sandbox.Services.CharacterService
{
    public interface ICharacterService
    {

        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}