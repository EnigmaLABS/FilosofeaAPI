using FilosofeaDomain.Entities;

namespace FilosofeaDomain.DTOInterfaces
{
    public interface IPutEntradaRequest
    {
        Entrada Entrada { get; set; }
    }
}