using DataAccessService.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessService.Servcies
{
    public interface IPeopleService
    {
        Task CreatePerson(PeopleViewModel peopleViewModel);
        Task<List<PeopleViewModel>> GetAllPeople();
    }
}