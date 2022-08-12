using GraphQL.Model.Context;
using GraphQL.Model.Entity;
using GraphQL.Model.Repository;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
    public class MovieQuery : ObjectGraphType
    {
        private readonly IMovieRepository _movieRepository;
        public MovieQuery(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
            Name = "Query";
            Field<ListGraphType<MovieType>>("movie", "Returns a list of Movie", resolve: context => _movieRepository.GetAll());

        }
    }
}