using FilosofeaData.Models;
using FilosofeaDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilosofeaData.Mapper.FiloMapper
{
    public static class BlogMapper
    {
        public static List<Entrada> Entrada_ToListDTO(List<Entradas> entradas)
        {
            List<Entrada> result = new List<Entrada>();

            foreach (var entrada in entradas)
            {
                Entrada newentry = new Entrada()
                {
                    IdEntrada = entrada.IdEntrada,
                    Hl1 = entrada.Hl1,
                    Hl2 = entrada.Hl2,
                    FhEntrada = entrada.FhEntrada,
                    Titulo = entrada.Titulo,

                    Usuario = UserMapper.toDTO(entrada.IdUsuarioNavigation),
                    Categorias = EntradaCategoria_ToListDTO(entrada.EntradasCategorias),
                    Autores = AutorMapper.Autor_toListDTO(entrada)
                };

                result.Add(newentry);
            }

            return result;
        }

        public static List<EntradaCategoria> EntradaCategoria_ToListDTO(ICollection<EntradasCategorias> entradasCategorias)
        {
            List<EntradaCategoria> result = new List<EntradaCategoria>();

            foreach (var entradaCategoria in entradasCategorias)
            {
                EntradaCategoria newcategory = new EntradaCategoria()
                {
                    idEntradaCategoria = entradaCategoria.IdEntradaCategoriaNavigation.IdEntradaCategoria,
                    Categoria = entradaCategoria.IdEntradaCategoriaNavigation.Categoria
                };

                result.Add(newcategory);
            }

            return result;
        }


    }
}
