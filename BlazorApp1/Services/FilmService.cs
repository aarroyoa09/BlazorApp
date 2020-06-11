using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using ClassLibrary1;
using ClassLibraryDapper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class FilmService : IFilmService
    {
        private readonly SqlConfig _configuration; 
        private InterfaceFilmRepository _filmRepository;

        public FilmService(SqlConfig config)
        {
            _configuration = config;
            _filmRepository = new FilmRepository(config.ConnectionString);
        }

        public Task<bool> DeleteFilm(int id)
        {
            return _filmRepository.DeleteFilm(id);
        }

        public Task<IEnumerable<Film>> GetAllFilms()
        {
            return _filmRepository.GetAllFilms();
        }

        public Task<Film> GetDetails(int id)
        {
            return _filmRepository.GetFilmDetails(id);
        }

        public Task<bool> Savefilm(Film film)
        {
            if (film.Id == 0)
                return _filmRepository.InsertFilm(film);
            else
                return _filmRepository.UpdateFilm(film);
        }
    }
}
