using AutoMapper;
using DataAccessService.DataAccess.PeopleDataAccess;
using DataAccessService.Models;
using DataAccessService.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessService.Servcies
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleData _peopleData;
        private readonly IMapper _mapper;
        public PeopleService(IPeopleData people, IMapper map)
        {
            this._peopleData = people;
            this._mapper = map;
        }

        public async Task<List<PeopleViewModel>> GetAllPeople()
        {
            try
            {
                var peopleVM = new List<PeopleViewModel>();
                var response = await this._peopleData.GetPeoples();
                var mapToVm = this._mapper.Map<List<PeopleViewModel>>(response);

                return mapToVm;
                //foreach (var person in response)
                //{
                //    peopleVM.Add(new PeopleViewModel
                //    {
                //        Id = person.id,
                //        FirstName = person.first_name,
                //        LastName = person.last_name,
                //        EmailAddress = person.email_address
                //    });
                //}

                // return peopleVM;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public async Task CreatePerson(PeopleViewModel peopleViewModel)
        {
            try
            {

                var mapModel = this._mapper.Map<People>(peopleViewModel);
                await this._peopleData.InsertPerson(mapModel);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
