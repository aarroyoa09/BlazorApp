using ClassLibrary1;
using ClassLibraryDapper.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;




namespace ClassLibraryDapper.Repositories
{
    public interface InterfaceFilmRepository
    {
        Task<IEnumerable<Film>> GetAllFilms();

        Task <Film> GetFilmDetails(int id);

        Task <bool> InsertFilm(Film film);

        Task <bool> UpdateFilm(Film film);

        Task <bool> DeleteFilm(int id);
    }
}
