using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Application.Repositories;
using TennisCourtBookings.Persistence.Context;
using TennisCourtBookings.Persistence.Repositories;
using TennisCourtBookings.Persistence.Services;

namespace TennisCourtBookings.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            var connectionString = configuration.GetConnectionString("ProductionString");
            services.AddDbContext<DataContext>(opt => opt.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITennisCourtRepository, TennisCourtRepository>();
            services.AddScoped<ICourtBookingsRepository, CourtBookingsRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddHttpContextAccessor();

        }
    }
}
