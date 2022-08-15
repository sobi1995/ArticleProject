using GraphQL;
using GraphQL.Model.Entity;
using GraphQL.Model.Repository;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
    public class MutationMovie : ObjectGraphType<object>
    {
        public MutationMovie(IMovieRepository repository)
        {
            Name = "Mutations";
            Description = "The base mutation for all the entities in our object graph.";

            FieldAsync<MovieType, Movie>(
                "addReview",
                "Add review to a movie.",
                new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>>
                    {
                        Name = "id",
                        Description = "The unique GUID of the movie."
                    },
                    new QueryArgument<NonNullGraphType<ReviewInputType>>
                    {
                        Name = "review",
                        Description = "Review for the movie."
                    }),
                context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    var review = context.GetArgument<Review>("review");
                    return repository.AddReviewToMovieAsync(id, review);
                });
        }

    }
}