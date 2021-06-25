using System;
using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;

namespace FilosofeaDomain.Entities
{
    public class Entrada : IEntrada
    {
        public long IdEntrada { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTime FhEntrada { get; set; }
        public string Hl1 { get; set; }
        public string Hl2 { get; set; }
        public IEnumerable<IEntradaCategoria> Categorias { get; set; }
        public IEnumerable<IAutor> Autores { get; set; }
        public IUsuario Usuario { get; set; }
    }
}
