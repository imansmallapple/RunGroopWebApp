using RunGroopWebApp.Models;

namespace RunGroopWebApp.Data.Interface
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>>GetAllUserClubs();
        Task<AppUser> GetUserById(string id);
    }
}
