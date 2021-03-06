﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using GraphQl.Entities;

namespace GraphQl.Data
{
    public partial class Digitallabs_CI_DEVELOPContext : DbContext
    {
        public Digitallabs_CI_DEVELOPContext()
        {
        }

        public Digitallabs_CI_DEVELOPContext(DbContextOptions<Digitallabs_CI_DEVELOPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AmsCamposAdicionaisColheitas> AmsCamposAdicionaisColheitas { get; set; }
        public virtual DbSet<AmsCamposAdicionaisRelColheita> AmsCamposAdicionaisRelColheita { get; set; }
        public virtual DbSet<AmsColheitaEtiquetas> AmsColheitaEtiquetas { get; set; }
        public virtual DbSet<AmsColheitaParametros> AmsColheitaParametros { get; set; }
        public virtual DbSet<AmsColheitas> AmsColheitas { get; set; }
        public virtual DbSet<AmsRelColheitas> AmsRelColheitas { get; set; }
        public virtual DbSet<ForensisambitoDiligencia> ForensisambitoDiligencia { get; set; }
        public virtual DbSet<Forensisatividade> Forensisatividade { get; set; }
        public virtual DbSet<ForensisatividadeDilig> ForensisatividadeDilig { get; set; }
        public virtual DbSet<Forensisbrigada> Forensisbrigada { get; set; }
        public virtual DbSet<ForensiscatInspetor> ForensiscatInspetor { get; set; }
        public virtual DbSet<Forensisdiligencia> Forensisdiligencia { get; set; }
        public virtual DbSet<ForensisequipaSlc> ForensisequipaSlc { get; set; }
        public virtual DbSet<ForensisguiaEntrega> ForensisguiaEntrega { get; set; }
        public virtual DbSet<ForensisguiaEntregaDet> ForensisguiaEntregaDet { get; set; }
        public virtual DbSet<ForensisimagemCroqui> ForensisimagemCroqui { get; set; }
        public virtual DbSet<Forensisrecolha> Forensisrecolha { get; set; }
        public virtual DbSet<ForensisregimeDiligencia> ForensisregimeDiligencia { get; set; }
        public virtual DbSet<Forensisvestigio> Forensisvestigio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ATADIBMADEMOS.cloudapp.net,49206;Initial Catalog=DL_LPC_DEV;User ID=ambsa;Password=#SA#2013sw2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AmsCamposAdicionaisColheitas>(entity =>
            {
                entity.HasKey(e => new { e.IdrelColheita, e.Idcolheita, e.Sequencia });

                entity.ToTable("AMS_CamposAdicionaisColheitas");

                entity.HasIndex(e => new { e.CodAtributo, e.IdrelColheita })
                    .HasName("IDX_AMS_CA_Colheitas_CodAtribRelColheita");

                entity.HasIndex(e => new { e.IdrelColheita, e.CodAtributo })
                    .HasName("IDX_AMS_CA_Colheitas_RelColheitaCodAtrib");

                entity.Property(e => e.IdrelColheita).HasColumnName("IDRelColheita");

                entity.Property(e => e.Idcolheita).HasColumnName("IDColheita");

                entity.Property(e => e.CampoColheita).HasMaxLength(1);

                entity.Property(e => e.ControlTs)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.AmsCamposAdicionaisColheitas)
                    .HasForeignKey(d => new { d.IdrelColheita, d.Idcolheita })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AMS_CamposAdicionaisColheitas_AMS_Colheitas");
            });

            modelBuilder.Entity<AmsCamposAdicionaisRelColheita>(entity =>
            {
                entity.HasKey(e => new { e.IdrelColheita, e.Sequencia, e.CodAtributo });

                entity.ToTable("AMS_CamposAdicionais_RelColheita");

                entity.HasIndex(e => new { e.CodAtributo, e.IdrelColheita })
                    .HasName("IDX_AMS_CA_RelColheita_CodAtribRelColheita");

                entity.HasIndex(e => new { e.IdrelColheita, e.CodAtributo })
                    .HasName("IDX_AMS_CA_RelColheita_RelColheitaCodAtrib");

                entity.Property(e => e.IdrelColheita).HasColumnName("IDRelColheita");

                entity.Property(e => e.ControlTs)
                    .HasColumnName("ControlTS")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Valor).HasColumnType("ntext");

                entity.Property(e => e.ValorRtf).HasColumnType("ntext");

                entity.HasOne(d => d.IdrelColheitaNavigation)
                    .WithMany(p => p.AmsCamposAdicionaisRelColheita)
                    .HasForeignKey(d => d.IdrelColheita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AMS_CamposAdicionais_RelColheita_AMS_RelColheitas");
            });

            modelBuilder.Entity<AmsColheitaEtiquetas>(entity =>
            {
                entity.HasKey(e => new { e.NrEtiqueta, e.Idcolheita, e.IdrelColheita })
                    .HasName("AMS_ColheitaEtiquetas_PK");

                entity.ToTable("AMS_ColheitaEtiquetas");

                entity.Property(e => e.Idcolheita).HasColumnName("IDColheita");

                entity.Property(e => e.IdrelColheita).HasColumnName("IDRelColheita");

                entity.Property(e => e.ControlTs)
                    .HasColumnName("ControlTS")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Descricao).IsRequired();

                entity.Property(e => e.TipoEtiqueta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.AmsColheitaEtiquetas)
                    .HasForeignKey(d => new { d.IdrelColheita, d.Idcolheita })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AMS_Colheitas_AMS_ColheitaEtiquetas_FK1");
            });

            modelBuilder.Entity<AmsColheitaParametros>(entity =>
            {
                entity.HasKey(e => new { e.IdrelColheita, e.Idcolheita, e.CodParametro });

                entity.ToTable("AMS_ColheitaParametros");

                entity.HasIndex(e => new { e.Idcolheita, e.CodParametro })
                    .HasName("UQ_AMS_ColheitaParametros_IDColheitaCodParam")
                    .IsUnique();

                entity.HasIndex(e => new { e.Idcolheita, e.CodParametro, e.CodMetodo })
                    .HasName("_AMB_index_AMS_ColheitaParametros_20150707_IcCpCm_CB");

                entity.Property(e => e.IdrelColheita).HasColumnName("IDRelColheita");

                entity.Property(e => e.Idcolheita).HasColumnName("IDColheita");

                entity.Property(e => e.CodLaboratorio).HasMaxLength(10);

                entity.Property(e => e.CodMetodo).HasMaxLength(50);

                entity.Property(e => e.ControlTs)
                    .HasColumnName("ControlTS")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DataPrevEntrega).HasColumnType("datetime");

                entity.Property(e => e.DataPrevEntregaOrig).HasColumnType("datetime");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.AmsColheitaParametros)
                    .HasForeignKey(d => new { d.IdrelColheita, d.Idcolheita })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AMS_ColheitaParametros_AMS_Colheitas");
            });

            modelBuilder.Entity<AmsColheitas>(entity =>
            {
                entity.HasKey(e => new { e.IdrelColheita, e.Idcolheita })
                    .HasName("AMS_Colheitas_PK");

                entity.ToTable("AMS_Colheitas");

                entity.HasIndex(e => e.CodAmostra)
                    .HasName("UIX_AMS_Colheitas_CodAmostra")
                    .IsUnique()
                    .HasFilter("([CodAmostra] IS NOT NULL)");

                entity.HasIndex(e => e.Idcolheita)
                    .HasName("UQ_AMS_Colheitas_IDColheita")
                    .IsUnique();

                entity.HasIndex(e => new { e.Idcolheita, e.CodAmostra })
                    .HasName("_AMB_index_AMS_Colheitas_20150707_IcCa_CB");

                entity.HasIndex(e => new { e.IdrelColheita, e.CodAmostra, e.Idcolheita })
                    .HasName("IDX_AMS_Colheitas_001");

                entity.HasIndex(e => new { e.IdrelColheita, e.Idcolheita, e.Estado })
                    .HasName("IX_AMS_Colheitas_Estado");

                entity.Property(e => e.IdrelColheita).HasColumnName("IDRelColheita");

                entity.Property(e => e.Idcolheita).HasColumnName("IDColheita");

                entity.Property(e => e.CodPonto)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ControlTs)
                    .HasColumnName("ControlTS")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Controlo).HasMaxLength(250);

                entity.Property(e => e.DataColheita).HasColumnType("datetime");

                entity.Property(e => e.DataColheitaOrig).HasColumnType("datetime");

                entity.Property(e => e.DataHoraColheita)
                    .HasColumnName("DataHora_Colheita")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPrevEntrega).HasColumnType("datetime");

                entity.Property(e => e.DataPrevEntregaOrig).HasColumnType("datetime");

                entity.Property(e => e.DescrColheita).HasColumnType("ntext");

                entity.Property(e => e.DescrColheitaRtf).HasColumnType("ntext");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExternalRef).HasMaxLength(250);

                entity.Property(e => e.IdsampleProduct).HasColumnName("IDSampleProduct");

                entity.HasOne(d => d.IdrelColheitaNavigation)
                    .WithMany(p => p.AmsColheitas)
                    .HasForeignKey(d => d.IdrelColheita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AMS_RelColheitas_AMS_Colheitas_FK1");
            });

            modelBuilder.Entity<AmsRelColheitas>(entity =>
            {
                entity.HasKey(e => e.IdrelColheita)
                    .HasName("AMS_RelColheitas_PK");

                entity.ToTable("AMS_RelColheitas");

                entity.Property(e => e.IdrelColheita)
                    .HasColumnName("IDRelColheita")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodCliente)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CodResponsavel)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ControlTs)
                    .HasColumnName("ControlTS")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DataColheita).HasColumnType("datetime");

                entity.Property(e => e.ExternalRef).HasMaxLength(250);

                entity.Property(e => e.IdentidadeBoletim)
                    .HasColumnName("IDEntidadeBoletim")
                    .HasMaxLength(10);

                entity.Property(e => e.IdentidadeRequisitante)
                    .HasColumnName("IDEntidadeRequisitante")
                    .HasMaxLength(10);

                entity.Property(e => e.IdentidadeValorizacao)
                    .HasColumnName("IDEntidadeValorizacao")
                    .HasMaxLength(10);

                entity.Property(e => e.Observacoes).HasColumnType("ntext");

                entity.Property(e => e.TipoColheita)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoTabPrecos).HasMaxLength(1);
            });

            modelBuilder.Entity<ForensisambitoDiligencia>(entity =>
            {
                entity.ToTable("FORENSISambitoDiligencia");

                entity.HasComment("Âmbitos da diligência Lista de âmbitos");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID Âmbito da Diligência (AUTO)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observacoes).IsUnicode(false);
            });

            modelBuilder.Entity<Forensisatividade>(entity =>
            {
                entity.ToTable("FORENSISatividade");

                entity.HasComment("Atividades a Executar Lista de atividades");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID Atividade a Executar (AUTO)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observacoes).IsUnicode(false);
            });

            modelBuilder.Entity<ForensisatividadeDilig>(entity =>
            {
                entity.HasKey(e => e.AtividadeId);

                entity.ToTable("FORENSISatividadeDilig");

                entity.HasComment("Atividades a Executar na Diligência  É necessário ter pelo menos 1 atividade a executar numa Diligência");

                entity.Property(e => e.AtividadeId)
                    .HasColumnName("AtividadeID")
                    .HasComment("ID da Atividade (a Executar)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiligId).HasColumnName("DiligID");

                entity.HasOne(d => d.Atividade)
                    .WithOne(p => p.ForensisatividadeDilig)
                    .HasForeignKey<ForensisatividadeDilig>(d => d.AtividadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISatividadeDilig_Atividade");

                entity.HasOne(d => d.Dilig)
                    .WithMany(p => p.ForensisatividadeDilig)
                    .HasForeignKey(d => d.DiligId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISatividadeDilig_Diligencia");
            });

            modelBuilder.Entity<Forensisbrigada>(entity =>
            {
                entity.ToTable("FORENSISbrigada");

                entity.HasComment("Brigada - da Unidade Requisitante ex: 3ª Brigada");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID Brigada (AUTO)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Descrição ex: 3ª Brigada");

                entity.Property(e => e.Observacoes).IsUnicode(false);
            });

            modelBuilder.Entity<ForensiscatInspetor>(entity =>
            {
                entity.ToTable("FORENSIScatInspetor");

                entity.HasComment("Categorias dos Inspetores  Coordenador Superior, Coordenador, Inspetor Chefe, Inspetor");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID Categoria (AUTO)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observacoes).IsUnicode(false);
            });

            modelBuilder.Entity<Forensisdiligencia>(entity =>
            {
                entity.ToTable("FORENSISdiligencia");

                entity.HasComment("Pedido de Diligência - Local do Crime  Pedido de Diligência / Intervenção");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID do Pedido de diligencia Nr. automático - <nº sequencial>  Numerador ModConfig")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmbitoId)
                    .HasColumnName("AmbitoID")
                    .HasComment("ID do Âmbito da diligência");

                entity.Property(e => e.BrigadaId)
                    .HasColumnName("BrigadaID")
                    .HasComment("Brigada da Entidade Requisitante Lista tabelada ex: 3ª Brigada");

                entity.Property(e => e.CatInspetorId)
                    .HasColumnName("CatInspetorID")
                    .HasComment("Categoria do inspetor responsável Lista tabelada");

                entity.Property(e => e.DtDiligencia)
                    .HasColumnType("datetime")
                    .HasComment("Data/Hora da diligência (Pedido de Intervenção)");

                entity.Property(e => e.DtFatos)
                    .HasColumnType("datetime")
                    .HasComment("Data/Hora da ocorrência dos fatos");

                entity.Property(e => e.EntidadeId)
                    .HasColumnName("EntidadeID")
                    .HasComment("Unidade/Entidade Requisitante Lista tabelada");

                entity.Property(e => e.Info)
                    .IsUnicode(false)
                    .HasComment("Outras informações");

                entity.Property(e => e.Inspetor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Nomde do inspetor responsável, no local do crime");

                entity.Property(e => e.Local)
                    .IsUnicode(false)
                    .HasComment("Local da ocorrência");

                entity.Property(e => e.Nuipc)
                    .IsRequired()
                    .HasColumnName("NUIPC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegimeDiligId)
                    .HasColumnName("RegimeDiligID")
                    .HasComment("ID Regime da Diligência");

                entity.Property(e => e.RubricaInspetor).HasComment("Assinatura do inspetor responsável (Imagem digitalizada)");

                entity.Property(e => e.SeccaoId)
                    .HasColumnName("SeccaoID")
                    .HasComment("Secção da Entidade Requisitante (Tabela EntMoradas) ex.: 1ª Secção");

                entity.Property(e => e.UnidadeLabId)
                    .HasColumnName("UnidadeLabID")
                    .HasComment("ID da Unidade Laboratorial Carregado com a UL  do Utilizador/Colaborador que regista a diligência  Usado para separar os dados de cada UL ");

                entity.HasOne(d => d.Ambito)
                    .WithMany(p => p.Forensisdiligencia)
                    .HasForeignKey(d => d.AmbitoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISdiligencia_AmbitoDiligencia");

                entity.HasOne(d => d.Brigada)
                    .WithMany(p => p.Forensisdiligencia)
                    .HasForeignKey(d => d.BrigadaId)
                    .HasConstraintName("FK_FORENSISdiligencia_Brigadas");

                entity.HasOne(d => d.CatInspetor)
                    .WithMany(p => p.Forensisdiligencia)
                    .HasForeignKey(d => d.CatInspetorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISdiligencia_CatInspetor");

                entity.HasOne(d => d.RegimeDilig)
                    .WithMany(p => p.Forensisdiligencia)
                    .HasForeignKey(d => d.RegimeDiligId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISdiligencia_RegimeDiligencia");
            });

            modelBuilder.Entity<ForensisequipaSlc>(entity =>
            {
                entity.HasKey(e => new { e.DiligId, e.PeritoId });

                entity.ToTable("FORENSISequipaSLC");

                entity.HasComment("Equipa do Local do Crime  Lista de Peritos que compõem uma equipa para a intervenção no Local do Crime  Terá que haver pelo menos 1 perito na equipa SLC e 1 responsável pelo relatório");

                entity.Property(e => e.DiligId)
                    .HasColumnName("DiligID")
                    .HasComment("ID Pedido de diligência");

                entity.Property(e => e.PeritoId)
                    .HasColumnName("PeritoID")
                    .HasComment("ID do Perito (Colaborador)");

                entity.Property(e => e.RespRelatorio).HasComment("Responsável pela elaboração do relatório 1/0");

                entity.HasOne(d => d.Dilig)
                    .WithMany(p => p.ForensisequipaSlc)
                    .HasForeignKey(d => d.DiligId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISequipaSLC_Diligencia");
            });

            modelBuilder.Entity<ForensisguiaEntrega>(entity =>
            {
                entity.ToTable("FORENSISguiaEntrega");

                entity.HasComment("Guias de Entrega");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID Guia de Entrega (AUTO)");

                entity.Property(e => e.DiligId)
                    .HasColumnName("DiligID")
                    .HasComment("ID Pedido de diligencia");

                entity.Property(e => e.EntidadeId)
                    .HasColumnName("EntidadeID")
                    .HasComment("Destinatário (Entidade)  Será a Entidade Requisitante ou o SAF-LPC");

                entity.HasOne(d => d.Dilig)
                    .WithMany(p => p.ForensisguiaEntrega)
                    .HasForeignKey(d => d.DiligId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISguiaEntrega_Diligencia");
            });

            modelBuilder.Entity<ForensisguiaEntregaDet>(entity =>
            {
                entity.HasKey(e => new { e.GuiaId, e.VestigioId });

                entity.ToTable("FORENSISguiaEntregaDet");

                entity.HasComment("Detalhe da Guia de Entrega Lista de Vestígios associada");

                entity.Property(e => e.GuiaId)
                    .HasColumnName("GuiaID")
                    .HasComment("ID Guia de Entrega");

                entity.Property(e => e.VestigioId)
                    .HasColumnName("VestigioID")
                    .HasComment("ID Vestígio");

                entity.Property(e => e.SacoProva)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refª do Saco Prova");

                entity.HasOne(d => d.Guia)
                    .WithMany(p => p.ForensisguiaEntregaDet)
                    .HasForeignKey(d => d.GuiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISguiaEntregaDet_GuiaEntrega");

                entity.HasOne(d => d.Vestigio)
                    .WithMany(p => p.ForensisguiaEntregaDet)
                    .HasForeignKey(d => d.VestigioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISguiaEntregaDet_Vestigio");
            });

            modelBuilder.Entity<ForensisimagemCroqui>(entity =>
            {
                entity.ToTable("FORENSISImagemCroqui");

                entity.HasComment("Imagens de fundo para Croquis");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID da Imagem para Croqui (AUTO)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Descrição");

                entity.Property(e => e.Imagem)
                    .IsRequired()
                    .HasComment("Imagem de fundo para o Croqui  PNG, JPG, GIF, BMP");

                entity.Property(e => e.Observacoes)
                    .IsUnicode(false)
                    .HasComment("Notas / Observações");
            });

            modelBuilder.Entity<Forensisrecolha>(entity =>
            {
                entity.HasKey(e => e.DiligId);

                entity.ToTable("FORENSISrecolha");

                entity.HasComment("Recolha de Vestígios - Local do Crime");

                entity.Property(e => e.DiligId)
                    .HasColumnName("DiligID")
                    .HasComment("ID Pedido de diligência")
                    .ValueGeneratedNever();

                entity.Property(e => e.Croqui).HasComment("Croqui/Esboço/Imagem   Guardamos aqui a imagem de fundo escolhida + as anotações por cima dessa imagem efetuadas pelo utilizador");

                entity.Property(e => e.DtRecolha)
                    .HasColumnType("datetime")
                    .HasComment("Data/Hora da Recolha");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasComment("Local/Morada/Veículo Local detalhado");

                entity.Property(e => e.LocalGps)
                    .HasColumnName("LocalGPS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Localização GPS da Recolha");

                entity.Property(e => e.Notas)
                    .IsUnicode(false)
                    .HasComment("Notas / observações");

                entity.HasOne(d => d.Dilig)
                    .WithOne(p => p.Forensisrecolha)
                    .HasForeignKey<Forensisrecolha>(d => d.DiligId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISrecolha_Diligencia");
            });

            modelBuilder.Entity<ForensisregimeDiligencia>(entity =>
            {
                entity.ToTable("FORENSISregimeDiligencia");

                entity.HasComment("Regime da Diligência  Classificador para análise estatística");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID Regime da Diligência (AUTO)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observacoes).IsUnicode(false);
            });

            modelBuilder.Entity<Forensisvestigio>(entity =>
            {
                entity.ToTable("FORENSISvestigio");

                entity.HasComment("Lista de Vestigios da Recolha  Atenção ao Código de Barras!");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID Vestigio (AUTO)  Não temos um módulo para Vestígios  Atenção ao Código de Barras!");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Descrição");

                entity.Property(e => e.DiligId)
                    .HasColumnName("DiligID")
                    .HasComment("ID Pedido de Diligência");

                entity.Property(e => e.DtRecolha)
                    .HasColumnType("datetime")
                    .HasComment("Data/Hora de Recolha do Vestígio");

                entity.Property(e => e.Local)
                    .IsUnicode(false)
                    .HasComment("Local de Recolha do Vestígio");

                entity.Property(e => e.LocalGps)
                    .HasColumnName("LocalGPS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Localização GPS do Vestígio");

                entity.Property(e => e.Notas)
                    .IsUnicode(false)
                    .HasComment("Notas / observações");

                entity.Property(e => e.PeritoId)
                    .HasColumnName("PeritoID")
                    .HasComment("Perito/Funcionário que efetuou a recolha  Deverá fazer parte da Equipa SLC");

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Nº / refª do vestígio");

                entity.Property(e => e.SacoProva)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Refª Saco Prova");

                entity.Property(e => e.TecnicaRecolha)
                    .IsUnicode(false)
                    .HasComment("Técnica de Recolha");

                entity.HasOne(d => d.Dilig)
                    .WithMany(p => p.Forensisvestigio)
                    .HasForeignKey(d => d.DiligId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISvestigio_Diligencia");

                entity.HasOne(d => d.ForensisequipaSlc)
                    .WithMany(p => p.Forensisvestigio)
                    .HasForeignKey(d => new { d.DiligId, d.PeritoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FORENSISvestigio_EquipaSLC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}