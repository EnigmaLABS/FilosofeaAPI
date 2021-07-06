using System.Collections.Generic;

using FilosofeaData.Models;
using FilosofeaDomain.Entities;

namespace FilosofeaData.Mapper.FiloMapper
{
    public static class AutorMapper
    {
        public static Autor Autor_toDTO(Autores autor)
        {
            Autor result = new Autor();

            if (autor != null)
            {
                result.IdAutor = autor.IdAutor;
                result.Nombre = autor.Nombre;
                result.FechaNacimiento = autor.FechaNacimiento;
                result.FechaFallecimiento = autor.FechaFallecimiento;
                result.Categorias = AutorCategoria_ToListDTO(autor.AutoresCategorias);
            }

            return result;
        }

        public static List<Autor> Autor_toListDTO(ICollection<Autores> autores)
        {
            List<Autor> result = new List<Autor>();

            foreach (var autor in autores)
            {
                result.Add(new Autor()
                {
                    IdAutor = autor.IdAutor,
                    Nombre = autor.Nombre,
                    FechaNacimiento = autor.FechaNacimiento,
                    FechaFallecimiento = autor.FechaFallecimiento,
                    Categorias = AutorCategoria_ToListDTO(autor.AutoresCategorias)
                });

            }

            return result;
        }

        public static List<Autor> Autor_toListDTO(Entradas entrada)
        {
            List<Autor> result = new List<Autor>();

            if (entrada.EntradasAutores != null)
            {
                foreach (var entradaAutor in entrada.EntradasAutores)
                {
                    result.Add(new Autor()
                    {
                        IdAutor = entradaAutor.IdAutor,
                        Nombre = entradaAutor.IdAutorNavigation?.Nombre,
                        FechaNacimiento = entradaAutor.IdAutorNavigation?.FechaNacimiento,
                        FechaFallecimiento = entradaAutor.IdAutorNavigation?.FechaFallecimiento,
                        Categorias = AutorCategoria_ToListDTO(entradaAutor.IdAutorNavigation?.AutoresCategorias)
                    });

                }
            }

            return result;
        }

        public static List<AutorCategoria> AutorCategoria_ToListDTO(ICollection<AutoresCategorias> autoresCategorias)
        {
            List<AutorCategoria> result = new List<AutorCategoria>();

            if (autoresCategorias != null)
            {
                foreach (var autorCategoria in autoresCategorias)
                {
                    AutorCategoria newcategory = new AutorCategoria()
                    {
                        idAutorCategoria = autorCategoria.IdAutorCategoria,
                        Categoria = autorCategoria.IdAutorCategoriaNavigation?.AutorCategoria
                    };

                    result.Add(newcategory);
                }
            }

            return result;
        }
    }
}
