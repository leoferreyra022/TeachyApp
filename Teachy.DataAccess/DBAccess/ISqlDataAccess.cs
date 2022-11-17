using System.Data;

namespace Teachy.DataAccess.DBAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> GetData<T, U>(string sp, U parameters, string connectionId = "Default");
        Task SaveData<T>(string sp, T parameters, string connectionId = "Default");
    }
}