using AutoMapper;
using dotnet_rpg.Models;
using dotnet_sandbox.Dtos.Character;

namespace dotnet_sandbox
{
    public class AutoMapperProfile: Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();

        }
        
    }
}