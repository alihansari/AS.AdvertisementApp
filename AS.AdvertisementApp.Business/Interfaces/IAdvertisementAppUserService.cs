using AS.AdvertisementApp.Common;
using AS.AdvertisementApp.Common.Enums;
using AS.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.Business.Interfaces
{
    public interface IAdvertisementAppUserService
    {
        Task<IResponse<AdvertisementAppUserCreateDto>> CreateAsync(AdvertisementAppUserCreateDto dto);
        public Task<List<AdvertisementAppUserListDto>> GetList(AdvertisementAppUserStatusType type);
        public Task SetStatusAsync(int advertisementAppUserId, AdvertisementAppUserStatusType type);

    }
}
