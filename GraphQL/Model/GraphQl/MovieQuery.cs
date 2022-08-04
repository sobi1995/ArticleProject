using GraphQL.Model.Context;
using GraphQL.Model.Entity;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
        public class MovieQuery : ObjectGraphType
    {
        private readonly MovieContext _movieContext;
        public MovieQuery(MovieContext movieContext)
        {
            this._movieContext = movieContext;
            Name = "Query";
            Field<ListGraphType<MovieType>>("movie", "Returns a list of Movie", resolve: context => _movieContext.Movie.ToList());
  
        }
    }
}