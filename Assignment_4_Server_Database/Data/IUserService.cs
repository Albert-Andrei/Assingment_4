using Assignment_4_Server_Database.Model;

namespace Assignment_4_Server_Database.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}