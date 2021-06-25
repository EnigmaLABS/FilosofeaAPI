using FilosofeaDomain.Enums;

namespace FilosofeaDomain.DomainInterfaces
{
    public interface IAutorCategoria
    {
        AutorCategoriaEnum AutorCategoriaType { get; }
        string Categoria { get; set; }
        int idAutorCategoria { get; set; }
    }
}