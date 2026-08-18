using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Todo.Infrastructure;
using Todo.Infrastructure.Entities;


namespace Todo.API
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration )
        {
            var connectionString = configuration.GetConnectionString("DatabaseConnection");

            services.AddDbContext<ToDoAppDbContext>(options => 
                        options.UseMySql(
                            connectionString,
                            ServerVersion.AutoDetect(connectionString)));

            return services;


        }
    }
}