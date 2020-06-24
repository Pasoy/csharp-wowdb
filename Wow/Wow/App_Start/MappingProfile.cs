using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Wow.Dtos;
using Wow.Models;

namespace Wow.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Player, PlayerDto>();
            Mapper.CreateMap<Character, CharacterDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Class, ClassDto>();
            Mapper.CreateMap<Race, RaceDto>();


            // Dto to Domain
            Mapper.CreateMap<PlayerDto, Player>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<CharacterDto, Character>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}