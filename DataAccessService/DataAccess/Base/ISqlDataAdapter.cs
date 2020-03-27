using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessService.DataAccess.Base
{
    public interface ISqlDataAdapter
    {
        string connectionString { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U param);
        Task SaveData<T>(string sql, T param);
    }
}