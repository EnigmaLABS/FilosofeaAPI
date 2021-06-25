using FilosofeaDomain.Enums;

namespace FilosofeaDomain.DomainInterfaces
{
    public interface IEntradaCategoria
    {
        string Categoria { get; set; }
        EntradaCategoriaEnum EntradaCategoriaType { get; }
        int idEntradaCategoria { get; set; }
    }
}