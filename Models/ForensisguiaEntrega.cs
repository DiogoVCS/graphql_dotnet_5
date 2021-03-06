﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace GraphQl.Entities
{
    /// <summary>
    /// Guias de Entrega
    /// </summary>
    public partial class ForensisguiaEntrega
    {
        public ForensisguiaEntrega()
        {
            ForensisguiaEntregaDet = new HashSet<ForensisguiaEntregaDet>();
        }

        /// <summary>
        /// ID Guia de Entrega (AUTO)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Destinatário (Entidade)  Será a Entidade Requisitante ou o SAF-LPC
        /// </summary>
        public int EntidadeId { get; set; }
        /// <summary>
        /// ID Pedido de diligencia
        /// </summary>
        public int DiligId { get; set; }

        public virtual Forensisdiligencia Dilig { get; set; }
        public virtual ICollection<ForensisguiaEntregaDet> ForensisguiaEntregaDet { get; set; }
    }
}