using FilosofeaData.Models;
using FilosofeaDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilosofeaData.Mapper.FiloMapper
{
    public static class UserMapper
    {
        public static Usuario toDTO(Usuarios usuario)
        {

            Usuario result = new Usuario()
            {
                IdUsuario = usuario.IdUsuario,
                NombreUsuario = usuario.Usuario
            };

            return result;
        }
    }
}
