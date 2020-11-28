using System.Collections.Generic;
using System.Threading.Tasks;
using Assigment_4_Code.Model;

namespace Assigment_4_Code.Data
{
    public interface IAdultServiceA
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task AddAdultsAsync(Adult adult);
        Task RemoveAdultsAsync(int personId);
        Task UpdateAdultsAsync(Adult adult);
    }
}