using System;
using System.Linq;
using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.DTOInterfaces;
using FilosofeaDomain.Entities;
using FilosofeaDomain.RepositoryInterfaces;
using FilosofeaDomain.ServiceInterfaces;

namespace FilosofeaBusiness.Services
{
    public class BlogService : IBlogService
    {
        private IBlogRepository _blogRepository;

        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IEnumerable<IEntrada> getEntradas(int idUser, IGetEntradasFilterRequest filterRequest)
        {
            List<Entrada> result = new List<Entrada>();

            if (filterRequest.FechaDesde != null && filterRequest.FechaHasta != null)
            {
                result = _blogRepository.GetEntradasByDate(idUser, (DateTime)filterRequest.FechaDesde, (DateTime)filterRequest.FechaHasta).ToList();
            }

            if (filterRequest.Autores != null)
            {
                if (result.Count > 0)
                {
                    this.filterByAutores(ref result, filterRequest.Autores.Select(ids => ids.IdAutor).ToList());
                }
                else
                {
                    result = _blogRepository.GetEntradasByAuthors(idUser, filterRequest.Autores).ToList();
                }
            }

            if (filterRequest.Categorias != null)
            {
                if (result.Count > 0)
                {
                    this.filterByCategories(ref result, filterRequest.Categorias.Select(ids => ids.idAutorCategoria).ToList());
                }
                else
                {
                    result = _blogRepository.GetEntradasByCategories(idUser, filterRequest.Categorias).ToList();
                }
            }

            return result;
        }

        private void getEntradas_ValidateRequest(IGetEntradasFilterRequest filterRequest)
        {

        }

        private void filterByCategories(ref List<Entrada> result, List<int> IdsCategorias) 
        {
            result = result.Where(f => f.Categorias.Any(i => IdsCategorias.Contains(i.idEntradaCategoria))).ToList();
        }
        private void filterByAutores(ref List<Entrada> result, List<long> IdsAutores)
        {
            result = result.Where(f => f.Autores.Any(i => IdsAutores.Contains(i.IdAutor))).ToList();
        }

    }
}
