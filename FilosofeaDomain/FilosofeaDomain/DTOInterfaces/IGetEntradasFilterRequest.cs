using FilosofeaDomain.DomainInterfaces;
using System;
using System.Collections.Generic;

namespace FilosofeaDomain.DTOInterfaces
{
    public interface IGetEntradasFilterRequest
    {
        IEnumerable<IAutor> Autores { get; set; }
        IEnumerable<IAutorCategoria> Categorias { get; set; }
        DateTime? FechaDesde { get; set; }
        DateTime? FechaHasta { get; set; }
    }
}