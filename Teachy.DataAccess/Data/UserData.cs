using Teachy.DataAccess.DBAccess;
using Teachy.DataAccess.Models;

namespace Teachy.DataAccess.Data
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _dataAccess;

        public UserData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<User>> GetUsers() =>
            await _dataAccess.GetData<User, dynamic>("[dbo].[s_Users_GetAll]", new { });

        public async Task<User?> GetUser(int id) =>
            (await _dataAccess.GetData<User, dynamic>("[dbo].[s_Users_Get]", new { Id = id })).FirstOrDefault();

        public async Task InsertUser(User user) =>
            await _dataAccess.SaveData("[dbo].[s_Users_Insert]", new { user.FirstName, user.LastName, user.NickName });

        public async Task UpdateUser(User user) =>
            await _dataAccess.SaveData("[dbo].[s_Users_Update]", new { user });

        public async Task DeleteUser(int id) =>
            await _dataAccess.SaveData("[dbo].[s_Users_Delete]", new { Id = id });
    }
}
