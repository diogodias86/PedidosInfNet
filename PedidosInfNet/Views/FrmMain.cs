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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            List<Pedido> pedidos;

            using (var db = new PedidosDbContext())
            {
                pedidos = db.Pedido.ToList();
            }

            table.DataSource = pedidos;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmPedido())
            {
                frm.ShowDialog();
            }
        }
    }
}
