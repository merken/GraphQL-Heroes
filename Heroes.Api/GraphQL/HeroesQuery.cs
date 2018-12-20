using GraphQL.Types;
using HeroApp.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Heroes.Api.GraphQL
{
    public class HeroesQuery : ObjectGraphType
    {
        public HeroesQuery(HeroesDbContext dbContext)
        {
            FieldAsync<HeroType>(
                "hero",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
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
        }
    }
}