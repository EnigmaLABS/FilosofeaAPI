using System;
using System.Collections.Generic;
using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.Entities;

namespace FilosofeaDomain.RepositoryInterfaces
{
    public interface IBlogRepository
    {
        IEnumerable<Entrada> GetEntradasByDate(int idUser, DateTime fechadesde, DateTime fechahasta);

        IEnumerable<Entrada> GetEntradasByCategories(int idUser, IEnumerable<IAutorCategoria> Categorias);

        IEnumerable<Entrada> GetEntradasByAuthors(int idUser, IEnumerable<IAutor> Autores);
    }
}