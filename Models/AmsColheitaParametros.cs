﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace GraphQl.Entities
{
    public partial class AmsColheitaParametros
    {
        public int IdrelColheita { get; set; }
        public int Idcolheita { get; set; }
        public int CodParametro { get; set; }
        public int Ordem { get; set; }
        public byte[] ControlTs { get; set; }
        public string CodMetodo { get; set; }
        public string CodLaboratorio { get; set; }
        public int? CodTipoColheita { get; set; }
        public int? CodGrupo { get; set; }
        public DateTime? DataPrevEntrega { get; set; }
        public DateTime? DataPrevEntregaOrig { get; set; }

        public virtual AmsColheitas Id { get; set; }
    }
}