using System;
using System.Collections.Generic;

using FilosofeaDomain.Entities;

namespace FilosofeaDomain.RepositoryInterfaces
{
    public interface IFiloRepository
    {
        Autor GetAutor(long id);
        IEnumerable<Autor> getAutoresByDate(DateTime fecha);
    }
}
