using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.Enums;

namespace FilosofeaDomain.Entities
{
    public class AutorCategoria : IAutorCategoria
    {
        public int idAutorCategoria { get; set; }

        public string Categoria { get; set; }

        public AutorCategoriaEnum AutorCategoriaType => (AutorCategoriaEnum)idAutorCategoria;
    }
}
