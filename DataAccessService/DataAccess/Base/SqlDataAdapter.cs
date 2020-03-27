using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessService.DataAccess.Base
{
    public class SqlDataAdapter : ISqlDataAdapter
    {
        private readonly IConfiguration _configuration;
        public string connectionString { get; set; } = "Default";
        public SqlDataAdapter(IConfiguration config)
        {
            this._configuration = config;
        }
        public async Task<List<T>> LoadData<T, U>(string sql, U param)
        {
            try
            {
                using (IDbConnection dbConnection = new NpgsqlConnection(this._configuration.GetConnectionString(connectionString)))
                {
                    var data = await dbConnection.QueryAsync<T>(sql, param);

                    return data.ToList();
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        //for CRUD operations
        public async Task SaveData<T>(string sql, T param)
        {
            try
            {
                using (IDbConnection dbConnection = new NpgsqlConnection(this._configuration.GetConnectionString(connectionString)))
                {
                    int response = await dbConnection.ExecuteAsync(sql, param);
                }
            }

            catch (System.Exception ex)
            {
                throw;
            }
        }

    }
}
