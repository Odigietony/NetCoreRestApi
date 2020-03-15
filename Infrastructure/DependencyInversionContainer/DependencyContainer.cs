using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DependencyInversionContainer
{
    public class DependencyContainer
    {
       public static void RegisterServices(IServiceCollection services)
       {
            //Infrastructure Layer
            services.AddScoped<IFacultyInterface, FacultyRepository>();
            services.AddScoped<IDepartmentInterface, DepartmentRepository>();
            services.AddScoped<ApplicationDbContext>();
       }
    }
}
