using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.DTOInterfaces;

namespace FilosofeaDomain.ServiceInterfaces
{
    public interface IBlogService
    {
        IEnumerable<IEntrada> getEntradas(int idUser, IGetEntradasFilterRequest filterRequest);

        void PutEntrada(IPutEntradaRequest putEntradaRequest);
    }
}