using FilosofeaDomain.Enums;

namespace FilosofeaDomain.DomainInterfaces
{
    public interface IEntradaCategoria
    {
        int idEntradaCategoria { get; set; }
        string Categoria { get; set; }
        EntradaCategoriaEnum EntradaCategoriaType { get; }
    }
}