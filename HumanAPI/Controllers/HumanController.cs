using AutoMapper;
using HumanAPI.Dto;
using HumanAPI.Interface;
using HumanAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HumanAPI.Controllers
{
    [Route("api/[controller]")]
    
    public class HumanController : ControllerBase
    {
        
        private readonly IHumanService _humanService;
        public HumanController(IHumanService humanService)
        {
            _humanService = humanService;
        }
        [HttpGet]
        public async Task<ActionResult<List<HumanModelDto>>> GetAllHumans()
        {
            return await _humanService.GetAllHuman();
            
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<HumanModelDto>>> DeleteHuman(int id)
        {
            var result = await _humanService.DeleteHuman(id);
            if (result == null)
            {
                return BadRequest("User not found");
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<List<HumanModel>>> AddHuman(HumanModel human)
        {
            var result = await _humanService.AddHuman(human);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<HumanModelDto>>> UpdateHuman(int id, HumanModelDto request)
        {
            var result = await _humanService.UpdateHuman(id, request);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<HumanModelDto>>> GetSingleHuman(int id)
        {
            var result = await _humanService.GetSingleHuman(id);
            if (result == null)
            {
                return BadRequest("User not found");
            }
            return Ok(result);
        }

    }
}
