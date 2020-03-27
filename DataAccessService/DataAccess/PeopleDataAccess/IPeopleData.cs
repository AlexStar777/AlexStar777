using DataAccessService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessService.DataAccess.PeopleDataAccess
{
    public interface IPeopleData
    {
        Task<List<People>> GetPeoples();
        Task InsertPerson(People people);
    }
}