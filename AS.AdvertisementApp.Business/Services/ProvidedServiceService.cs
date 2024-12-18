﻿using AS.AdvertisementApp.Business.Interfaces;
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
    public class ProvidedServiceService:Service<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto, ProvidedService>,IProvidedServiceService
    {
        public ProvidedServiceService(IMapper mapper,IValidator<ProvidedServiceCreateDto> createDtoValidator,IValidator<ProvidedServiceUpdateDto> updateDtoValidator,IUow uow)
            :base(mapper, createDtoValidator, updateDtoValidator, uow)
        {

        }
    }
}
