using System.Collections.Generic;

using FilosofeaData.Models;
using FilosofeaDomain.Entities;

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

        public static Entrada Entrada_ToDTO(Entradas entrada)
        {
            Entrada result = new Entrada()
            {
                IdEntrada = entrada.IdEntrada,
                Hl1 = entrada.Hl1,
                Hl2 = entrada.Hl2,
                FhEntrada = entrada.FhEntrada,
                Titulo = entrada.Titulo,
                Texto = entrada.Texto,

                Usuario = UserMapper.toDTO(entrada.IdUsuarioNavigation),
                Categorias = EntradaCategoria_ToListDTO(entrada.EntradasCategorias),
                Autores = AutorMapper.Autor_toListDTO(entrada)
            };

            return result;
        }

        public static List<EntradaCategoria> EntradaCategoria_ToListDTO(ICollection<EntradasCategorias> entradasCategorias)
        {
            List<EntradaCategoria> result = new List<EntradaCategoria>();

            if (entradasCategorias != null)
            {
                foreach (var entradaCategoria in entradasCategorias)
                {
                    EntradaCategoria newcategory = new EntradaCategoria()
                    {
                        idEntradaCategoria = entradaCategoria.IdEntradaCategoria,
                        Categoria = entradaCategoria.IdEntradaCategoriaNavigation?.Categoria
                    };

                    result.Add(newcategory);
                }
            }

            return result;
        }

        public static Entradas Entrada_ToEntity(Entrada entrada)
        {
            Entradas result = new Entradas();

            result.Titulo = entrada.Titulo;
            result.Texto = entrada.Texto;
            result.Hl1 = entrada.Hl1;
            result.Hl2 = entrada.Hl2;

            result.IdEstadoEntrada = entrada.estadosEntradas.idEstadoEntrada;
            result.IdUsuario = entrada.Usuario.IdUsuario;

            result.EntradasAutores = new List<EntradasAutores>();

            foreach (var autor in entrada.Autores)
            {
                result.EntradasAutores.Add(new EntradasAutores()
                {
                    IdAutor = autor.IdAutor
                });
            }

            result.EntradasCategorias = new List<EntradasCategorias>();

            foreach (var categoria in entrada.Categorias)
            {
                result.EntradasCategorias.Add(new EntradasCategorias()
                {
                    IdEntradaCategoria = categoria.idEntradaCategoria
                });
            }

            return result;
        }

    }
}
