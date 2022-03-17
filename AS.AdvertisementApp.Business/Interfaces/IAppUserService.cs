using AS.AdvertisementApp.Dtos;
using AS.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.Business.Interfaces
{
    public interface IAppUserService :IService<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser>
    {

    }
}
