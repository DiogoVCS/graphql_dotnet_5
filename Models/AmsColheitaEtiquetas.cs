﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace GraphQl.Entities
{
    public partial class AmsColheitaEtiquetas
    {
        public int IdrelColheita { get; set; }
        public int Idcolheita { get; set; }
        public int NrEtiqueta { get; set; }
        public string Descricao { get; set; }
        public byte[] ControlTs { get; set; }
        public string TipoEtiqueta { get; set; }

        public virtual AmsColheitas Id { get; set; }
    }
}