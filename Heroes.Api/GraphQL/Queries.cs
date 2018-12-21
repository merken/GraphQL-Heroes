using GraphQL.Types;
using HeroApp.Data.Domain;
using HeroApp.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Heroes.Api.GraphQL
{
    public interface IQuery
    {
    }

    public class HeroesQuery : ObjectGraphType, IQuery
    {
        public HeroesQuery(HeroesDbContext dbContext)
        {
            FieldAsync<HeroType>(
                "hero",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    return await dbContext.Heroes.AsNoTracking().FirstAsync(h => h.Id == id);
                }
            );

            FieldAsync<ListGraphType<HeroType>>(
                "heroes",
                resolve: async context =>
                {
                    return await dbContext.Heroes.AsNoTracking().ToListAsync();
                }
            );

            FieldAsync<AbilityType>(
                "ability",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    return await dbContext.Set<Ability>().AsNoTracking().FirstAsync(h => h.Id == id);
                }
            );

            FieldAsync<ListGraphType<AbilityType>>(
                "abilities",
                resolve: async context =>
                {
                    return await dbContext.Set<Ability>().AsNoTracking().ToListAsync();
                }
            );

            FieldAsync<MovieType>(
                "movie",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    return await dbContext.Movies.AsNoTracking().FirstAsync(h => h.Id == id);
                }
            );

            FieldAsync<ListGraphType<MovieType>>(
                "movies",
                resolve: async context =>
                {
                    return await dbContext.Movies.AsNoTracking().ToListAsync();
                }
            );

            FieldAsync<TeamType>(
                "team",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    return await dbContext.Teams.AsNoTracking().FirstAsync(h => h.Id == id);
                }
            );

            FieldAsync<ListGraphType<TeamType>>(
                "teams",
                resolve: async context =>
                {
                    return await dbContext.Teams.AsNoTracking().ToListAsync();
                }
            );

            FieldAsync<WeaponType>(
                "weapon",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    return await dbContext.Set<Weapon>().AsNoTracking().FirstAsync(h => h.Id == id);
                }
            );

            FieldAsync<ListGraphType<WeaponType>>(
                "weapons",
                resolve: async context =>
                {
                    return await dbContext.Set<Weapon>().AsNoTracking().ToListAsync();
                }
            );
        }
    }
}