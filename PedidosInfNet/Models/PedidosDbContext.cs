namespace PedidosInfNet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PedidosDbContext : DbContext
    {
        public PedidosDbContext()
            : base("name=PedidosInfNet")
        {
        }

        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaFisica> PessoaFisica { get; set; }
        public virtual DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.ValorUnitario)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pedido>()
                .HasMany(e => e.Item)
                .WithRequired(e => e.Pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.PessoaFisica)
                .WithRequired(e => e.Pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.PessoaJuridica)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<PessoaFisica>()
                .Property(e => e.Sexo)
                .IsFixedLength();

            modelBuilder.Entity<PessoaFisica>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.PessoaFisica)
                .HasForeignKey(e => e.CodigoComprador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PessoaJuridica>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.PessoaJuridica)
                .HasForeignKey(e => e.CodigoVendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PessoaJuridica>()
                .HasMany(e => e.Produto)
                .WithRequired(e => e.PessoaJuridica)
                .HasForeignKey(e => e.CodigoFornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Preco)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.Item)
                .WithRequired(e => e.Produto)
                .WillCascadeOnDelete(false);
        }
    }
}
