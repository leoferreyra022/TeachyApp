using Teachy.DataAccess.Models;

namespace Teachy.DataAccess.Data
{
    public interface IUserData
    {
        Task DeleteUser(int id);
        Task<User?> GetUser(int id);
        Task<IEnumerable<User>> GetUsers();
        Task InsertUser(User user);
        Task UpdateUser(User user);
    }
}