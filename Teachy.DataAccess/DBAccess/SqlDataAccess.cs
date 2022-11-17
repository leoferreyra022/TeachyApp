using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Teachy.DataAccess.DBAccess;

public class SqlDataAccess : ISqlDataAccess
{
	private readonly IConfiguration _config;

	public SqlDataAccess(IConfiguration config)
	{
		_config = config;
	}

	public async Task<IEnumerable<T>> GetData<T, U>(
		string sp,
		U parameters,
		string connectionId = "Default")
	{
		using var connection = new SqlConnection(_config.GetConnectionString(connectionId));

		return await connection.QueryAsync<T>(sp, parameters, commandType: CommandType.StoredProcedure);
	}

	public async Task SaveData<T>(
		string sp,
		T parameters,
		string connectionId = "Default")
	{
		using var connection = new SqlConnection(_config.GetConnectionString(connectionId));

		await connection.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
	}
}
