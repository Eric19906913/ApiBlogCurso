using ApiBlog.Domain.DTOs;
using ApiBlog.Entities;
using AutoMapper;

namespace ApiBlog.Domain.Profilers
{
    public class UserProfiler : Profile
    {
        public UserProfiler() 
        {
            CreateMap<User, UserHeaderDto>().ForMember(x => x.Name)
        }
    }
}
