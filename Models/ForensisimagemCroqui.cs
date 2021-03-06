﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace GraphQl.Entities
{
    /// <summary>
    /// Imagens de fundo para Croquis
    /// </summary>
    public partial class ForensisimagemCroqui
    {
        /// <summary>
        /// ID da Imagem para Croqui (AUTO)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Descrição
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Imagem de fundo para o Croqui  PNG, JPG, GIF, BMP
        /// </summary>
        public byte[] Imagem { get; set; }
        /// <summary>
        /// Notas / Observações
        /// </summary>
        public string Observacoes { get; set; }
    }
}