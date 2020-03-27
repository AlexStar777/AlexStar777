using DataAccessService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessService.DataAccess.Base;

namespace DataAccessService.DataAccess.PeopleDataAccess
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAdapter _db;

        public PeopleData(ISqlDataAdapter sqlData)
        {
            this._db = sqlData;
        }

        public async Task<List<People>> GetPeoples()
        {
            string sql = @"select * from public.people";
            var query = await this._db.LoadData<People, dynamic>(sql, new { });

            return query;
        }

        public async Task InsertPerson(People people)
        {
            string sql = @"insert into public.people(first_name, last_name, email_address) 
                       values(@first_name,@last_name,@email_address)";
            try
            {
                await this._db.SaveData<People>(sql, people);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
