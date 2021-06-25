using System;
using System.Collections.Generic;
using System.Linq;

using FilosofeaData.Context;
using FilosofeaData.Mapper.FiloMapper;
using FilosofeaDomain.DomainInterfaces;
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
            var result = _context.Entradas.Where(e => e.FhEntrada > fechadesde && e.FhEntrada < fechahasta)
                                            .Include(usu => usu.IdUsuarioNavigation)
                                            .Include(cat => cat.EntradasCategorias)
                                                .ThenInclude(c => c.IdEntradaCategoriaNavigation)
                                            .Include(aut => aut.EntradasAutores)
                                                .ThenInclude(a => a.IdAutorNavigation)
                                                    .ThenInclude(cataut => cataut.AutoresCategorias)
                                                        .ThenInclude(cat => cat.IdAutorCategoriaNavigation);

            return BlogMapper.Entrada_ToListDTO(result.ToList());
        }

        public IEnumerable<Entrada> GetEntradasByCategories(int idUser, IEnumerable<IAutorCategoria> Categorias)
        {
            var result = from entrada in _context.Entradas
                         join ae in _context.EntradasAutores on entrada.IdEntrada equals ae.IdEntrada
                         join cat in _context.AutoresCategorias on ae.IdAutor equals cat.IdAutor
                         where entrada.IdUsuario == idUser && Categorias.Select(x => x.idAutorCategoria).Contains(cat.IdAutorCategoria)
                         select entrada;

            return BlogMapper.Entrada_ToListDTO(result.ToList());
        }

        public IEnumerable<Entrada> GetEntradasByAuthors(int idUser, IEnumerable<IAutor> Autores)
        {
            var result = from entrada in _context.Entradas
                         join ae in _context.EntradasAutores on entrada.IdEntrada equals ae.IdEntrada
                         where entrada.IdUsuario == idUser && Autores.Select(x => x.IdAutor).Contains(ae.IdAutor)
                         select entrada;

            return BlogMapper.Entrada_ToListDTO(result.ToList());
        }
    }
}
