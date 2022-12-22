using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Net5TestApp.Business.Interfaces;
using Net5TestApp.Business.Mappings.AutoMapper;
using Net5TestApp.Business.Services;
using Net5TestApp.Business.ValidationRules.AdvertisementValidators;
using Net5TestApp.Business.ValidationRules.ProvidedServiceValidators;
using Net5TestApp.DataAccess.Concrete.EfCore.Context;
using Net5TestApp.DataAccess.Concrete.UnitOfWork;
using Net5TestApp.Dtos.Concrete.AdvertisementDtos;
using Net5TestApp.Dtos.Concrete.ProvidedServiceDtos;

namespace Net5TestApp.Business.DependencyResolvers
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });

            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new ProvidedServiceProfile());
                opt.AddProfile(new AdvertisementProfile());
            });
            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<IValidator<ProvidedServiceCreateDto>, ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();

            services.AddScoped<IUow, Uow>();
            services.AddScoped<IProvidedServiceService, ProvidedServiceService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
        }
    }
}
