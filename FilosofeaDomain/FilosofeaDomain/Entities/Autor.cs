using System;
using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;

namespace FilosofeaDomain.Entities
{
    public class Autor : IAutor
    {
        public long IdAutor { get; set; }
        public string Nombre { get; set; }
        public string Pseudonimo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaFallecimiento { get; set; }
        public DateTime? FhCreacion { get; set; }
        public IEnumerable<IAutorCategoria> Categorias { get; set; }
    }
}
