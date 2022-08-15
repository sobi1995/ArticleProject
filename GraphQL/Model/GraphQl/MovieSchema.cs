using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
        public class MovieSchema : Schema
        {
            public MovieSchema(IServiceProvider serviceProvider) : base(serviceProvider)
            {
                Query = serviceProvider.GetRequiredService<MovieQuery>();
               Mutation = serviceProvider.GetRequiredService<MutationMovie>();
        }
        }
}