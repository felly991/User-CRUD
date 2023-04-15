using AutoMapper;
using HumanAPI.Configuration;
using HumanAPI.Data;
using HumanAPI.Dto;
using HumanAPI.Interface;
using HumanAPI.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace HumanAPI.Service
{
    public class HumanService : IHumanService
    {
        private static List<HumanModel> humanModel = new List<HumanModel>()
        {

        };

        private readonly IMapper _mapper;
        

        private readonly DataContext _context;
        public HumanService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<HumanModelDto>> AddHuman(HumanModel model)
        {
            var human = _mapper.Map<HumanModelDto>(model);
            _context.HumanModels.Add(model);
            await _context.SaveChangesAsync();
            return _context.HumanModels.Select(human => _mapper.Map<HumanModelDto>(human)).ToList();
        }

        public async Task<List<HumanModelDto>> DeleteHuman(int id)
        {
            var human = await _context.HumanModels.FindAsync(id);
            if (human == null)
            {
                return null;
            }
            _context.HumanModels.Remove(human);
            await _context.SaveChangesAsync();
            var humans = await _context.HumanModels.ToListAsync();
            return humans.Select(human => _mapper.Map<HumanModelDto>(human)).ToList(); ;
        }

        public async Task<List<HumanModelDto>> GetAllHuman()
        {
            var humans = await _context.HumanModels.ToListAsync();
            
            return humans.Select(human => _mapper.Map<HumanModelDto>(human)).ToList();
        }

        public async Task<HumanModelDto> GetSingleHuman(int id)
        {

            var human = await _context.HumanModels.FindAsync(id);
            var ret = _mapper.Map<HumanModelDto>(human);
            if (human == null)
            {
                return null;
            }
            return ret;

        }

        public async Task<List<HumanModelDto>> UpdateHuman(int id, HumanModelDto request)
        {
            var human = await _context.HumanModels.FindAsync(id);
            if (human == null)
            {
                return null;
            }
            human.FirstName = request.FirstName;
            human.LastName = request.LastName;
            human.Sex = request.Sex;
            human.Age = request.Age;
            human.Company = request.Company;
            human.FamilyStatus = request.FamilyStatus;
            human.BirthDate = request.BirthDate;
            await _context.SaveChangesAsync();
            var humans = await _context.HumanModels.ToListAsync();

            return humans.Select(h => _mapper.Map<HumanModelDto>(h)).ToList();

        }
    }
}
