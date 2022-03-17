using AS.AdvertisementApp.Business.Interfaces;
using AS.AdvertisementApp.DataAccess.UnitOfWork;
using AS.AdvertisementApp.Dtos;
using AS.AdvertisementApp.Entities;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.Business.Services
{
    public class AppUserManager : Service<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser> , IAppUserService
    {
        public AppUserManager(IMapper mapper, IValidator<AppUserCreateDto> createDtoValidator,IValidator<AppUserUpdateDto> updateDtoValidator,IUow uow):base(mapper,createDtoValidator,updateDtoValidator,uow)
        {

        }
    }
}
