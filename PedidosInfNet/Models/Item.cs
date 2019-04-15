namespace PedidosInfNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [Key]
        public int CodigoItem { get; set; }

        public int CodigoPedido { get; set; }

        public int CodigoProduto { get; set; }

        public int Qtd { get; set; }

        public decimal ValorUnitario { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
