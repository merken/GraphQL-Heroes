using GraphQL.Types;
using HeroApp.Data.Domain;

namespace Heroes.Api.GraphQL
{
    public class HeroType : ObjectGraphType<Hero>
    {
        public HeroType()
        {
            Field(h => h.Id);
            Field(h => h.Name);
            Field(h => h.Description);
        }
    }
}