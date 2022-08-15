using GraphQL;
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
            Name = "Queries";
            Description = "The base query for all the entities in our object graph.";
            this._movieRepository = movieRepository;


            FieldAsync<ListGraphType<MovieType>>("moviereview", "Returns a list of Movie", resolve: async context =>await _movieRepository.GetAll());

            FieldAsync<MovieType, Movie>(
             "movie",
             "Gets a movie by its unique identifier.",
             new QueryArguments(
                 new QueryArgument<NonNullGraphType<IdGraphType>>
                 {
                     Name = "id",
                     Description = "The unique GUID of the movie."
                 }),
             context =>     _movieRepository.GetMovieByIdAsync(context.GetArgument("id", Guid.Empty)));

        }
    }
}