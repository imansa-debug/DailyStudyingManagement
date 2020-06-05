using DSM.Application.Interfaces;
using DSM.Application.Services;
using DSM.Domain.Interfaces;
using DSM.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSM.Infra.IoC
{
    public class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer 
            service.AddScoped<ICourseService, CourseService>();

            //Infra Data Layer
            service.AddScoped<ICourseRepository, CourseRepository>();


        }
    }
}
