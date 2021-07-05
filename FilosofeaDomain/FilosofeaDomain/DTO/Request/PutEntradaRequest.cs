using FilosofeaDomain.DTOInterfaces;
using FilosofeaDomain.Entities;

namespace FilosofeaDomain.DTO.Request
{
    public class PutEntradaRequest : IPutEntradaRequest
    {
        public Entrada Entrada { get; set; }
    }
}
