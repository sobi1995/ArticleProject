using GraphQL.Model.Entity;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
    public class ReviewInputType : InputObjectGraphType<Review>
    {
        public ReviewInputType()
        {
            Name = "ReviewInput";
            Description = "A review of the movie";

            Field(r => r.Reviewer).Description("Name of the reviewer");
            Field(r => r.Stars).Description("Star rating out of five");
        }
    }
}