using BetBoomMVC.Domain.Entities;

namespace BetBoomMVC.Application.Services
{
    public interface ISportTypeService
    {
        Task<IEnumerable<SportType>> GetSportTypesAsync();
    }
}
