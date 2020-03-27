using AutoMapper;
using DataAccessService.Models;
using DataAccessService.ViewModels;

namespace DataAccessService.Mappings
{
    public class PeopleMappingProfile : Profile
    {
        public PeopleMappingProfile()
        {
            base.CreateMap<PeopleViewModel, People>().ForMember(
               dest => dest.id,
               from => from.MapFrom(vm => vm.Id))
               .ForMember(
                dest => dest.first_name,
                from => from.MapFrom(vm => vm.FirstName))
               .ForMember(
                dest => dest.last_name,
                from => from.MapFrom(vm => vm.LastName))
               .ForMember(
                dest => dest.email_address,
                from => from.MapFrom(vm => vm.EmailAddress));
        }
    }
}
