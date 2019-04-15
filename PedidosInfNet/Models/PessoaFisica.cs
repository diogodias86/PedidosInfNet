namespace PedidosInfNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PessoaFisica")]
    public partial class PessoaFisica
    {
        public PessoaFisica()
        {
            Pedido = new HashSet<Pedido>();
        }

        [Key]
        public int CodigoPF { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        public int CodigoPessoa { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
