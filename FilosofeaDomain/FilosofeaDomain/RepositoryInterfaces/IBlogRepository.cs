using FilosofeaDomain.Entities;
using System;
using System.Collections.Generic;

namespace FilosofeaDomain.RepositoryInterfaces
{
    public interface IBlogRepository
    {
        IEnumerable<Entrada> GetEntradasByDate(int idUser, DateTime fechadesde, DateTime fechahasta);
    }
}