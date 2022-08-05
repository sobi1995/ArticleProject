using GraphQL.Model.Entity;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
    public class MovieType : ObjectGraphType<Movie>
    {
        public MovieType()
        {
            Name = "Movie";
            Description = "Movie Type";
            
            Field(d => d.Id, nullable: false).Description("Movie Id");
            Field(d => d.Name, nullable: true).Description("Movie Name");
            Field(d => d.Price, nullable: true).Description("Movie Price");
        }
    }
}