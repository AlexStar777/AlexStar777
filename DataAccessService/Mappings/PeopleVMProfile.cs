using AutoMapper;
using DataAccessService.Models;
using DataAccessService.ViewModels;

namespace DataAccessService.Mappings
{
    public class PeopleVMProfile : Profile
    {
        public PeopleVMProfile()
        {
            base.CreateMap<People, PeopleViewModel>().ForMember(
                dest => dest.Id,
                from => from.MapFrom(entity => entity.id))
                .ForMember(
                dest => dest.FirstName,
                from => from.MapFrom(entity => entity.first_name))
                .ForMember(
                dest => dest.LastName,
                from => from.MapFrom(entity => entity.last_name))
                .ForMember(
                dest => dest.EmailAddress,
                from => from.MapFrom(entity => entity.email_address));
        }
    }
}
