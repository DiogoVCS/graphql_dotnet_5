﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace GraphQl.Entities
{
    /// <summary>
    /// Categorias dos Inspetores  Coordenador Superior, Coordenador, Inspetor Chefe, Inspetor
    /// </summary>
    public partial class ForensiscatInspetor
    {
        public ForensiscatInspetor()
        {
            Forensisdiligencia = new HashSet<Forensisdiligencia>();
        }

        /// <summary>
        /// ID Categoria (AUTO)
        /// </summary>
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Observacoes { get; set; }

        public virtual ICollection<Forensisdiligencia> Forensisdiligencia { get; set; }
    }
}