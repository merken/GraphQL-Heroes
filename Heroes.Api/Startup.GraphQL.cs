using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.DataLoader;
using GraphQL.Http;
using GraphQL.Types;
using Heroes.Api.GraphQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Heroes.Api
{
    public partial class Startup
    {
        public void ConfigureGraphQL(IServiceCollection services)
        {
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<ISchema, HeroesSchema>();

            services = AddQueryTypes(services);
            services = AddDomainTypes(services);

            services.AddSingleton<IDataLoaderContextAccessor, DataLoaderContextAccessor>();
            services.AddSingleton<DataLoaderDocumentListener>();
        }

        private IServiceCollection AddQueryTypes(IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            var assemblies = new[] { typeof(Startup).Assembly };
            services = UseAllOfType<IQuery>(services, assemblies, (iFace, type) =>
            {
                return new ServiceDescriptor(type, type, lifetime);
            });

            return services;
        }

        private IServiceCollection AddDomainTypes(IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            var assemblies = new[] { typeof(Startup).Assembly };
            services = UseAllOfType<IDomainType>(services, assemblies, (iFace, type) =>
            {
                return new ServiceDescriptor(type, type, lifetime);
            });

            return services;
        }

        private static IServiceCollection UseAllOfType<T>(IServiceCollection serviceCollection,
            Assembly[] assemblies,
            Func<Type, Type, ServiceDescriptor> serviceDescriptionFactory)
        {
            var typesFromAssemblies = assemblies.SelectMany(a => a.DefinedTypes.Where(x => x.IsClass && x.GetInterfaces().Contains(typeof(T))));
            foreach (var type in typesFromAssemblies)
                serviceCollection.Add(serviceDescriptionFactory(typeof(T), type));

            return serviceCollection;
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void ConfigureGraphQLMiddleware(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMiddleware<GraphQLMiddleware>();
        }
    }
}
