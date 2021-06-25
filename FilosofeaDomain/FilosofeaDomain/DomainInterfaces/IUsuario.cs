namespace FilosofeaDomain.DomainInterfaces
{
    public interface IUsuario
    {
        int IdUsuario { get; set; }
        string Mail { get; set; }
        string NombreUsuario { get; set; }
    }
}