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
        public IEnumerable<EntradaCategoria> Categorias { get; set; }
        public IEnumerable<Autor> Autores { get; set; }
        public Usuario Usuario { get; set; }
        public EstadosEntradas estadosEntradas { get; set; }
    }

    public class EstadosEntradas : IEstadosEntradas
    {
        public int idEstadoEntrada { get; set; }
        public string Descripcion { get; set; }
    }
}
