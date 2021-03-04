using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProAPI.Dto;
using ProAPI.Models;
using ProAPI.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ProAPI.Repo;

namespace ProAPI.Controllers
{
    [Route("api/command")]
    [ApiController]
    public class ProController : ControllerBase
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
       
        public ProController(IRepo repository, IMapper mapper)
        {
            _repo = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public  ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commndItems = _repo.GetAllCommands();
            var GetData= _mapper.Map<IEnumerable<CommandReadDto>>(commndItems);

            return Ok(GetData);
            //return CreatedAtRoute(nameof(GetCommandByID), new { ID = GetData.id}, GetData);
        }

        [HttpGet("{id}", Name = "GetCommandByID")]
        public ActionResult<CommandReadDto> GetCommandByID(int id)
        {
            var commndItem = _repo.GetCommandByID(id);
            if (commndItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commndItem));
            }
            return NotFound();
        }


        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repo.CreateCommand(commandModel);
            _repo.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandByID), new { ID = commandReadDto.id }, commandReadDto);
            //return Ok(commandReadDto); 
        }
    }
}
