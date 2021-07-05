using FilosofeaDomain.Entities;
using System;
using System.Collections.Generic;

namespace FilosofeaDomain.DomainInterfaces
{
    public interface IEntrada
    {
        DateTime FhEntrada { get; set; }
        string Hl1 { get; set; }
        string Hl2 { get; set; }
        long IdEntrada { get; set; }
        string Texto { get; set; }
        string Titulo { get; set; }
        IEnumerable<EntradaCategoria> Categorias { get; set; }
        IEnumerable<Autor> Autores { get; set; }
        Usuario Usuario { get; set; }
        EstadosEntradas estadosEntradas { get; set; }
    }
}