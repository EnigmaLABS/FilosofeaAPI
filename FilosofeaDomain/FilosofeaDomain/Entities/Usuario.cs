using FilosofeaDomain.DomainInterfaces;

namespace FilosofeaDomain.Entities
{
    public class Usuario : IUsuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Mail { get; set; }
    }
}
