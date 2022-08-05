using GraphQL.Model.Context;
using GraphQL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Model.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public  List<Movie>  GetAll()
        {
            
            return _context.Movie.ToList();
        }

        public Task<Movie> GetMovieByIdAsync(Guid id)
        {
            return _context.Movie.Where(m => m.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

       
    }
}
