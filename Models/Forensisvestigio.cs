﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace GraphQl.Entities
{
    /// <summary>
    /// Lista de Vestigios da Recolha  Atenção ao Código de Barras!
    /// </summary>
    public partial class Forensisvestigio
    {
        public Forensisvestigio()
        {
            ForensisguiaEntregaDet = new HashSet<ForensisguiaEntregaDet>();
        }

        /// <summary>
        /// ID Vestigio (AUTO)  Não temos um módulo para Vestígios  Atenção ao Código de Barras!
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ID Pedido de Diligência
        /// </summary>
        public int DiligId { get; set; }
        /// <summary>
        /// Nº / refª do vestígio
        /// </summary>
        public string Ref { get; set; }
        /// <summary>
        /// Descrição
        /// </summary>
        public string Descr { get; set; }
        /// <summary>
        /// Refª Saco Prova
        /// </summary>
        public string SacoProva { get; set; }
        /// <summary>
        /// Local de Recolha do Vestígio
        /// </summary>
        public string Local { get; set; }
        /// <summary>
        /// Localização GPS do Vestígio
        /// </summary>
        public string LocalGps { get; set; }
        /// <summary>
        /// Data/Hora de Recolha do Vestígio
        /// </summary>
        public DateTime DtRecolha { get; set; }
        /// <summary>
        /// Perito/Funcionário que efetuou a recolha  Deverá fazer parte da Equipa SLC
        /// </summary>
        public int PeritoId { get; set; }
        /// <summary>
        /// Técnica de Recolha
        /// </summary>
        public string TecnicaRecolha { get; set; }
        /// <summary>
        /// Notas / observações
        /// </summary>
        public string Notas { get; set; }

        public virtual Forensisdiligencia Dilig { get; set; }
        public virtual ForensisequipaSlc ForensisequipaSlc { get; set; }
        public virtual ICollection<ForensisguiaEntregaDet> ForensisguiaEntregaDet { get; set; }
    }
}