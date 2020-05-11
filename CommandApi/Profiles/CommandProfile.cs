using AutoMapper;
using CommandApi.Dtos;
using CommandApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandApi.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>(); 
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
