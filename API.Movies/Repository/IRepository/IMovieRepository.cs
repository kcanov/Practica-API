using API.Movies.DAL.Models;

namespace API.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync(); //Me retorna una lista de Peliculas
        Task<Movie> GetMovieAsync(int id); //Me retorna una pelicula por ID
        Task<bool> CreateMovieAsync(Movie movie); //Me crea una pelicula
        Task<bool> UpdateMovieAsync(Movie movie); //Me crea una pelicula --puedo actualizar el nombre y la fecha de actualizacion
        Task<bool> DeleteMovieAsync(int id); //Me elimina una pelicula
        Task<bool> MovieExistsByIdAsync(int id); //Me dice si existe una pelicula por ID
        Task<bool> MovieExistsByNameAsync(string name); //Me dice si existe una pelicula por Nombre
    }
}