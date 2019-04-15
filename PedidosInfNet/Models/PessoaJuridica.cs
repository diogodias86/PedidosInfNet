namespace PedidosInfNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PessoaJuridica")]
    public partial class PessoaJuridica
    {
        public PessoaJuridica()
        {
            Pedido = new HashSet<Pedido>();
            Produto = new HashSet<Produto>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoPJ { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        public bool Ativa { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
