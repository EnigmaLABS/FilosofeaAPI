﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FilosofeaData.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Entradas = new HashSet<Entradas>();
        }

        [Key]
        [Column("idUsuario")]
        public int IdUsuario { get; set; }
        [StringLength(155)]
        public string Usuario { get; set; }
        [StringLength(155)]
        public string Mail { get; set; }
        [Column("fhCreacion", TypeName = "datetime")]
        public DateTime? FhCreacion { get; set; }

        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Entradas> Entradas { get; set; }
    }
}