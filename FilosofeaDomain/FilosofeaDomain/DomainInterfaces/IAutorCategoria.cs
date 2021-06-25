using FilosofeaDomain.Enums;

namespace FilosofeaDomain.DomainInterfaces
{
    public interface IAutorCategoria
    {       
        int idAutorCategoria { get; set; }
        string Categoria { get; set; }
        AutorCategoriaEnum AutorCategoriaType { get; }
    }
}