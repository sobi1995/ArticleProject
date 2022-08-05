using GraphQL.Model.Entity;

namespace GraphQL.Model.Repository
{
    public interface IMovieRepository
    {
        Task<Movie> GetMovieByIdAsync(Guid id);
         List<Movie>  GetAll();
   
    }
}
