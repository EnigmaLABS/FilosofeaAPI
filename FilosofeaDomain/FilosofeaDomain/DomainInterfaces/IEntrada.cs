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
        IEnumerable<IEntradaCategoria> Categorias { get; set; }
        IEnumerable<IAutor> Autores { get; set; }
        IUsuario Usuario { get; set; }
    }
}