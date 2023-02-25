using DotNetTest.BLL;
using DotNetTest.DAL;
using DotNetTest.DAL.DesignPattern;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.IOC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            #region DAL

            services.AddScoped(typeof(IUnitOfWork<DAL.AppContext>), typeof(UnitOfWork<DAL.AppContext>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #endregion


            #region Bll
            services.AddScoped(typeof(DriverBll));
            #endregion


        }
    }

}
