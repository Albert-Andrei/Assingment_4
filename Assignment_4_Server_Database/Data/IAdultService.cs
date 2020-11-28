using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_4_Server_Database.Model;

namespace Assignment_4_Server_Database.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task<Adult> AddAdultsAsync(Adult adult);
        Task RemoveAdultsAsync(int personId);
        Task UpdateAdultsAsync(Adult adult);
    }
}