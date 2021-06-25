using FilosofeaDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilosofeaDomain.RepositoryInterfaces
{
    public interface IFiloRepository
    {
        Autor GetAutor(long id);
        IEnumerable<Autor> getAutoresByDate(DateTime fecha);
    }
}
