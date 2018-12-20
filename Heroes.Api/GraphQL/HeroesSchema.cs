using GraphQL.Types;

namespace Heroes.Api.GraphQL
{
    public class HeroesSchema : Schema
    {
        public HeroesSchema(HeroesQuery query)
        {
            Query = query;
        }
    }
}