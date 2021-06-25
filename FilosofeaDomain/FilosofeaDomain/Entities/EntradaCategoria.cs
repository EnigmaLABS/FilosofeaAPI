using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.Enums;

namespace FilosofeaDomain.Entities
{
    public class EntradaCategoria : IEntradaCategoria
    {
        public int idEntradaCategoria { get; set; }

        public string Categoria { get; set; }

        public EntradaCategoriaEnum EntradaCategoriaType => (EntradaCategoriaEnum)idEntradaCategoria;
    }
}
