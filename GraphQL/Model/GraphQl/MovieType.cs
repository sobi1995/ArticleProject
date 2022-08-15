using GraphQL.Model.Entity;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
    public class MovieType : ObjectGraphType<Movie>
    {
        public MovieType()
        {

            Name = nameof(Movie);
            Description = "A movie in the collection";


            Field(d => d.Price, nullable: true).Description("Movie Price");
            Field(m => m.Id).Description("Identifier of the movie");
            Field(m => m.Name).Description("Name of the movie");
            Field(
                name: "Reviews",
                description: "Reviews of the movie",
                type: typeof(ListGraphType<ReviewType>),
                resolve: m => m.Source.Reviews);
        }
    }
}