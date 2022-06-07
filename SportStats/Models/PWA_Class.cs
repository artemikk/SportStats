using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportStats.Data;
using System;
using System.Linq;

namespace SportStats.Models
{
    public static class PWA_Class
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddProgressiveWebApp();
        }
    }
}