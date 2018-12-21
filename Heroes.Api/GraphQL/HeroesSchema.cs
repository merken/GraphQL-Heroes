using GraphQL;
using GraphQL.Types;

namespace Heroes.Api.GraphQL
{
    public class HeroesSchema : Schema
    {
        public HeroesSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<HeroesQuery>();
        }
    }
}