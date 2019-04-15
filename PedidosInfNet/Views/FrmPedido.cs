using PedidosInfNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosInfNet.Views
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            using (var db = new PedidosDbContext())
            {
                var pedido = new Pedido
                {
                    CodigoPedido = Convert.ToInt32(txtCodigo.Text),
                    CodigoComprador = 1,
                    CodigoVendedor = 1,
                    DataPedido = dtPedido.Value
                };

                db.Pedido.Add(pedido);
                db.SaveChanges();
            }
        }
    }
}
