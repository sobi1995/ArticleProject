using GraphQL.Model.Entity;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
    public class MovieType : ObjectGraphType<Movie>
    {
        public MovieType()
        {
            Name = "Note";
            Description = "Note Type";
            Field(d => d.Id, nullable: false).Description("Note Id");
            Field(d => d.Name, nullable: true).Description("Note Message");
        }
    }
}