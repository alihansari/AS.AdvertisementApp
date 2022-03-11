using AS.AdvertisementApp.Business.Interfaces;
using AS.AdvertisementApp.Common;
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
    public class AdvertisementManager : Service<AdvertisementCreateDto, AdvertisementUpdateDto, AdvertisementListDto, Advertisement>, IAdvertisementManager
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public AdvertisementManager(IMapper mapper, IValidator<AdvertisementCreateDto> createDtoValidator, IValidator<AdvertisementUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
            _uow = uow;
        }
        public async Task<IResponse<List<AdvertisementListDto>>> GetActivesAsync()
        {
            var data = await _uow.GetRepository<Advertisement>().GetAllAsync(x => x.Status, x => x.CreatedDate, Common.Enums.OrderByType.DESC);
            var dto = _mapper.Map<List<AdvertisementListDto>>(data);
            return new Response<List<AdvertisementListDto>>(ResponseType.Success, dto);
        }
    }
}
