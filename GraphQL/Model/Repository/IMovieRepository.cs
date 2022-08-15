using GraphQL.Model.Entity;

namespace GraphQL.Model.Repository
{
    public interface IMovieRepository
    {
        Task<Movie> GetMovieByIdAsync(Guid id);
        Task<Movie> AddReviewToMovieAsync(Guid id, Review review);
        Task<List<Movie>> GetAll();
   
    }
}
