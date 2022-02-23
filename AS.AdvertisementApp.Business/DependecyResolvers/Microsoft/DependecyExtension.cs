using AS.AdvertisementApp.Business.Interfaces;
using AS.AdvertisementApp.Business.Mappings.AutoMapper;
using AS.AdvertisementApp.Business.Services;
using AS.AdvertisementApp.Business.ValidationRules;
using AS.AdvertisementApp.DataAccess.Contexts;
using AS.AdvertisementApp.DataAccess.UnitOfWork;
using AS.AdvertisementApp.Dtos.ProvidedServiceDtos;
using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.Business.DependecyResolvers.Microsoft
{
    public static class DependecyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });
            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new ProvidedServiceProfile());
                //opt.AddProfile();
            });
            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IUow, Uow>();

            services.AddTransient<IValidator<ProvidedServiceCreateDto>, ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();

            services.AddScoped<IProvidedServiceManager, ProvidedServiceManager>();
        }
    }
}
