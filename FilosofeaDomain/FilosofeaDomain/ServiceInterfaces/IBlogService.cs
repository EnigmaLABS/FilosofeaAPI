using System;
using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;

namespace FilosofeaDomain.ServiceInterfaces
{
    public interface IBlogService
    {
        IEnumerable<IEntrada> getEntradas(int idUser, DateTime? fechadesde, DateTime? fechahasta, int? top);
    }
}