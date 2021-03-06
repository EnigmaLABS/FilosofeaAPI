// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FilosofeaData.Models
{
    [Table("Obras_Categorias")]
    public partial class ObrasCategorias
    {
        [Key]
        [Column("idObra")]
        public long IdObra { get; set; }
        [Key]
        [Column("idObraCategoria")]
        public int IdObraCategoria { get; set; }

        [ForeignKey(nameof(IdObraCategoria))]
        [InverseProperty(nameof(ObrasCategoriasTipos.ObrasCategorias))]
        public virtual ObrasCategoriasTipos IdObraCategoriaNavigation { get; set; }
        [ForeignKey(nameof(IdObra))]
        [InverseProperty(nameof(Obras.ObrasCategorias))]
        public virtual Obras IdObraNavigation { get; set; }
    }
}