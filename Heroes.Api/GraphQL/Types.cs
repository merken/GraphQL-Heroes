using System;
using System.Linq;
using GraphQL;
using GraphQL.DataLoader;
using GraphQL.Types;
using HeroApp.Data.Domain;
using HeroApp.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Heroes.Api.GraphQL
{
    public interface IDomainType
    {
    }

    public class HeroType : ObjectGraphType<Hero>, IDomainType
    {
        public HeroType()
        {
            Field(h => h.Id);
            Field(h => h.Name);
            Field(h => h.Description);
            //Already loaded via .Include (EF)
            Field<SecretIdentityType, SecretIdentity>("secretIdentity").Resolve(ctx => ctx.Source.SecretIdentity);
        }
    }

    public class SecretIdentityType : ObjectGraphType<SecretIdentity>, IDomainType
    {
        public SecretIdentityType()
        {
            Field(h => h.FirstName);
            Field(h => h.LastName);
        }
    }

    public class AbilityType : ObjectGraphType<Ability>, IDomainType
    {
        public AbilityType()
        {
            Field(a => a.Id);
            Field(a => a.Name);
            Field(a => a.Advantage);
        }
    }

    public class MovieType : ObjectGraphType<Movie>, IDomainType
    {
        public MovieType()
        {
            Field(m => m.Id);
            Field(m => m.Title);
            Field(m => m.Image);
            Field(m => m.PlotSummary);
            Field(m => m.ReleaseDate);

        }
    }

    public class TeamType : ObjectGraphType<Team>, IDomainType
    {
        public TeamType(HeroesDbContext dbContext, IDataLoaderContextAccessor accessor)
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Description);
            Field<HeroType, Hero>()
                .Name("leader")
                .ResolveAsync(ctx =>
                {
                    var dataLoader = accessor.Context.GetOrAddBatchLoader<int, Hero>("GetHeroById", async (ids) =>
                    {
                        return await dbContext.Heroes.AsNoTracking().Where(h => ids.Contains(h.Id)).ToDictionaryAsync(x => x.Id);
                    });
                    return dataLoader.LoadAsync(ctx.Source.LeaderId);
                });
            Field<MovieType, Movie>()
                .Name("movie")
                .ResolveAsync(ctx =>
                {
                    var dataLoader = accessor.Context.GetOrAddBatchLoader<int, Movie>("GetMovieById", async (ids) =>
                    {
                        return await dbContext.Movies.AsNoTracking().Where(m => ids.Contains(m.Id)).ToDictionaryAsync(x => x.Id);
                    });
                    return dataLoader.LoadAsync(ctx.Source.MovieId);
                });
        }
    }

    public class WeaponType : ObjectGraphType<Weapon>, IDomainType
    {
        public WeaponType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Description);
        }
    }
}