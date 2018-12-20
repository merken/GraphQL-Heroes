using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using HeroApp.Data.Model;
using Heroes.Api.GraphQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Heroes.Api
{
    public partial class Startup
    {
        public void ConfigureHeroesDbContext(IServiceCollection services)
        {
            services.AddDbContext<HeroesDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("HeroesDb"));
            });
        }
    }
}
