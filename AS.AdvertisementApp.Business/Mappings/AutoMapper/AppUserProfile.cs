using AS.AdvertisementApp.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUserProfile, AppUserListDto>().ReverseMap();
            CreateMap<AppUserProfile, AppUserUpdateDto>().ReverseMap();
            CreateMap<AppUserProfile, AppUserCreateDto>().ReverseMap();
        }
    }
}
