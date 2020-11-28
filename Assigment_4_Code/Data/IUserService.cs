using System.Threading.Tasks;
using Assigment_4_Code.Model;

namespace Assigment_4_Code.Data
{
    public interface IUserService
    {
        Task<User> GetUserAsync(string? username, string? password);
    }
}