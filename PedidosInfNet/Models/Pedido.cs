namespace PedidosInfNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido
    {
        public Pedido()
        {
            Item = new HashSet<Item>();
        }

        [Key]
        public int CodigoPedido { get; set; }

        public int CodigoComprador { get; set; }

        public int CodigoVendedor { get; set; }

        public DateTime DataPedido { get; set; }

        public virtual ICollection<Item> Item { get; set; }

        public virtual PessoaFisica PessoaFisica { get; set; }

        public virtual PessoaJuridica PessoaJuridica { get; set; }

        public static implicit operator Pedido(Pedido v)
        {
            throw new NotImplementedException();
        }
    }
}
