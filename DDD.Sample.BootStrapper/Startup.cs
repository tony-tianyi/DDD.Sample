using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Owin;

namespace DDD.Sample.BootStrapper
{
    public class Startup
    {
        public static void Configure()
        {
            //configure ioc

            ConfigureMapper();
        }

        private static void ConfigureMapper()
        {
            //configure automapper dtos
        }

        //public void ConfigureServices(IAppBuilder app)
        //{
        //    GlobalConfiguration.Configuration.UseSqlServerStorage("Data Source=171.15.17.85,6633;Initial Catalog=Banu_0412;User ID=sa;Password=BnXnlkp5566");
        //    app.UseHangfireDashboard();
        //    app.UseHangfireServer();
        //}


    }
}
