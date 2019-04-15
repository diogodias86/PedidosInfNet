namespace PedidosInfNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pessoa")]
    public partial class Pessoa
    {
        public Pessoa()
        {
            PessoaFisica = new HashSet<PessoaFisica>();
        }

        [Key]
        public int CodigoPessoa { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Endereco { get; set; }

        public virtual ICollection<PessoaFisica> PessoaFisica { get; set; }

        public virtual PessoaJuridica PessoaJuridica { get; set; }
    }
}
