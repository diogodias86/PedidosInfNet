namespace PedidosInfNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produto")]
    public partial class Produto
    {
        public Produto()
        {
            Item = new HashSet<Item>();
        }

        [Key]
        public int CodigoProduto { get; set; }

        [Required]
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int CodigoFornecedor { get; set; }

        public virtual ICollection<Item> Item { get; set; }

        public virtual PessoaJuridica PessoaJuridica { get; set; }
    }
}
