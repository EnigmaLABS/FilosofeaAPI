using System;
using System.Collections.Generic;

namespace FilosofeaDomain.DomainInterfaces
{
    public interface IAutor
    {
        DateTime? FechaFallecimiento { get; set; }
        DateTime? FechaNacimiento { get; set; }
        DateTime? FhCreacion { get; set; }
        long IdAutor { get; set; }
        string Nombre { get; set; }
        string Pseudonimo { get; set; }
        IEnumerable<IAutorCategoria> Categorias { get; set; }
    }
}