using System;
using System.Linq;
using System.Collections.Generic;

using FilosofeaData.Mapper.FiloMapper;
using FilosofeaData.Context;
using FilosofeaDomain.Entities;
using FilosofeaDomain.RepositoryInterfaces;

namespace FilosofeaData.Repositories
{
    public class FiloRepository : IFiloRepository
    {
        private FilosofeadbContext _context;

        public FiloRepository(FilosofeadbContext context)
        {
            _context = context;
        }

        public Autor GetAutor(long id)
        {
            var result = _context.Autores.FirstOrDefault(a => a.IdAutor == id);

            return AutorMapper.Autor_toDTO(result);
        }

        public IEnumerable<Autor> getAutoresByDate(DateTime fecha)
        {
            var result = _context.Autores.Where(a => a.FechaNacimiento > fecha.AddYears(-1) && a.FechaNacimiento < fecha.AddYears(1));

            return AutorMapper.Autor_toListDTO(result.ToList());
        }
    }
}
