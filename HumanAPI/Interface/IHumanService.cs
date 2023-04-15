using HumanAPI.Dto;
using HumanAPI.Models;

namespace HumanAPI.Interface
{
    public interface IHumanService
    {
        Task<List<HumanModelDto>> GetAllHuman();
        Task<HumanModelDto> GetSingleHuman(int id);
        Task<List<HumanModelDto>> AddHuman(HumanModel human);
        Task<List<HumanModelDto>> UpdateHuman(int id, HumanModelDto human);
        Task<List<HumanModelDto>> DeleteHuman(int id);
    }
}
