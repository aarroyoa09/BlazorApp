using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Interfaces
{
    public interface IFilmService
    {        
        Task<IEnumerable<Film>> GetAllFilms();

        Task<Film> GetDetails(int id);

        Task<bool> DeleteFilm(int id);

        Task<bool> Savefilm(Film film);

    }
}
