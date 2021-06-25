using System;
using System.Collections.Generic;
using System.Linq;

using FilosofeaData.Context;
using FilosofeaData.Mapper.FiloMapper;
using FilosofeaDomain.Entities;
using FilosofeaDomain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace FilosofeaData.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private FilosofeadbContext _context;

        public BlogRepository(FilosofeadbContext context)
        {
            _context = context;
        }

        public IEnumerable<Entrada> GetEntradasByDate(int idUser, DateTime fechadesde, DateTime fechahasta)
        {
            try
            {
                var result = _context.Entradas.Where(e => e.FhEntrada != null)
                                              .Include(usu => usu.IdUsuarioNavigation)
                                              .Include(cat => cat.EntradasCategorias)
                                                    .ThenInclude(c => c.IdEntradaCategoriaNavigation)
                                              .Include(aut => aut.EntradasAutores)
                                                    .ThenInclude(a => a.IdAutorNavigation)
                                                        .ThenInclude(cataut => cataut.AutoresCategorias)
                                                            .ThenInclude(cat => cat.IdAutorCategoriaNavigation);

                return BlogMapper.Entrada_ToListDTO(result.ToList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
