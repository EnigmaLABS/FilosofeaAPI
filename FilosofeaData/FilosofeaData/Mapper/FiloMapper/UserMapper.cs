using FilosofeaData.Models;
using FilosofeaDomain.Entities;

namespace FilosofeaData.Mapper.FiloMapper
{
    public static class UserMapper
    {
        public static Usuario toDTO(Usuarios usuario)
        {
            Usuario result = new Usuario();

            if (usuario != null)
            {
                result.IdUsuario = usuario.IdUsuario;
                result.NombreUsuario = usuario.Usuario;
            }

            return result;
        }
    }
}
