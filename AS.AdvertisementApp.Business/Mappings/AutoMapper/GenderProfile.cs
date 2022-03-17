using AS.AdvertisementApp.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class GenderProfile : Profile
    {
        public GenderProfile()
        {
            CreateMap<GenderProfile, GenderListDto>().ReverseMap();
            CreateMap<GenderProfile, GenderCreateDto>().ReverseMap();
            CreateMap<GenderProfile, GenderUpdateDto>().ReverseMap();
        }
    }
}
