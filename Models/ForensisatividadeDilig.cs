﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace GraphQl.Entities
{
    /// <summary>
    /// Atividades a Executar na Diligência  É necessário ter pelo menos 1 atividade a executar numa Diligência
    /// </summary>
    public partial class ForensisatividadeDilig
    {
        /// <summary>
        /// ID da Atividade (a Executar)
        /// </summary>
        public int AtividadeId { get; set; }
        public int DiligId { get; set; }

        public virtual Forensisatividade Atividade { get; set; }
        public virtual Forensisdiligencia Dilig { get; set; }
    }
}