using Application.Abstraction.Repositories;
using Application.Abstraction.Services;
using Application.Common.Interfaces.Common;
using Application.ExternalAPI;
using ExternalAPI.Email;
using Infrastructure.Implementation.Common;
using Infrastructure.Implementation.Repositories;
using Infrastructure.Implementation.Services;
using Microsoft.Extensions.DependencyInjection;



namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            #region Service   
            
            services.AddTransient<ISendGridEmail, SendGridEmail>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IImportantNumberService, ImportantNumberService>();
            services.AddTransient<IHospitalService, HospitalService>();

            #endregion

            #region Repository

            services.AddTransient<IRequestBuilder, RequestBuilder>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IImportantNumberRepository, ImportantNumberRepository>(); 
            services.AddTransient<IHospitalRepository, HospitalRepository>();
            #endregion
        }

    }
}
