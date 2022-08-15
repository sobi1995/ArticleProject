using GraphQL.Model.Entity;
using GraphQL.Types;

namespace Web.GraphQL.Model.GraphQl
{
    public class ReviewType : ObjectGraphType<Review>
    {
        public ReviewType()
        {
            Name = nameof(Review);
            Description = "A review of the movie";

            Field(r => r.Reviewer).Description("Name of the reviewer");
            Field(r => r.Stars).Description("Star rating out of five");
        }
    }
}