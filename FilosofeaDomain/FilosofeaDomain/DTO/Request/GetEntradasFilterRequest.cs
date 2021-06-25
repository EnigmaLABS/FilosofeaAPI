using System;
using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.DTOInterfaces;

namespace FilosofeaDomain.DTO.Request
{
    public class GetEntradasFilterRequest : IGetEntradasFilterRequest
    {
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public IEnumerable<IAutorCategoria> Categorias { get; set; }
        public IEnumerable<IAutor> Autores { get; set; }

    }
}
