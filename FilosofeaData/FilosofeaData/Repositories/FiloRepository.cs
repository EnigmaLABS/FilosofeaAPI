using System.Linq;

using FilosofeaData.Mapper.FiloMapper;
using FilosofeaData.Context;
using FilosofeaDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
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
            try
            {
                var result = _context.Autores.FirstOrDefault(a => a.IdAutor == id);

                return AutorMapper.Autor_toDTO(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Autor> getAutoresByDate(DateTime fecha)
        {
            var result = _context.Autores.Where(a => a.FechaNacimiento > fecha.AddYears(-1) && a.FechaNacimiento < fecha.AddYears(1));
            throw new NotImplementedException();
        }
    }
}
