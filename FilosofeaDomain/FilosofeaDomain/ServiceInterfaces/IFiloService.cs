using System;
using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;

namespace FilosofeaDomain.ServiceInterfaces
{
    public interface IFiloService
    {
        IAutor getAutor(long id);
        IEnumerable<IAutor> getAutoresByDate(DateTime fecha);
    }
}
