using GraphQL.Model.Entity;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
    public class MovieQuery : ObjectGraphType
    {
        public MovieQuery()
        {
            Field<ListGraphType<MovieType>>("notes", resolve: context => new List<Movie> {
      new Movie { Id = Guid.NewGuid(), Name = "Hello World!" },
      new Movie { Id = Guid.NewGuid(), Name = "Hello World! How are you?" }
    });
        }
    }
}