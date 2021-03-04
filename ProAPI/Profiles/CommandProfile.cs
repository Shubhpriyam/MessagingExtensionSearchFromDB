using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProAPI.Dto;
using ProAPI.Models;

namespace ProAPI.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            //SOurce - > target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
        }
    }
}
