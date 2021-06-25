using FilosofeaDomain.DomainInterfaces;
using System;
using System.Collections.Generic;

namespace FilosofeaDomain.ServiceInterfaces
{
    public interface IBlogService
    {
        IEnumerable<IEntrada> getEntradas(int idUser, DateTime? fechadesde, DateTime? fechahasta, int? top);
    }
}