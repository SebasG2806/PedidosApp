using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class HistorialPedidos : Form
    {
        public HistorialPedidos()
        {
            InitializeComponent();
            CargarHistorial();
            CargarEntrega();
        }

        private void HistorialPedidos_Load(object sender, EventArgs e)
        {

        }
        private void CargarHistorial()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Tipo entrega", typeof(string));
            dt.Columns.Add("Costo entrega", typeof(string));
            List<Pedido> pedidos = RegistroPedidos.Instancia.ObtenerPedido();
            foreach (Pedido pedido in pedidos)
            {
                dt.Rows.Add(pedido.Cliente, pedido.Producto, pedido.MetodoEntrega.TipoEntrega(), $"${pedido.ObtenerCosto():N2}");
            }
            dgvHistorial.DataSource = dt;
        }
        private void CargarEntrega()
        {
            List<string> tiposEntrega = RegistroPedidos.Instancia.ObtenerTiposEntrega();
            cmbTipoEntrega.Items.Add("Todos");
            cmbTipoEntrega.Items.AddRange(tiposEntrega.ToArray());
            cmbTipoEntrega.SelectedIndex = 0;
        }
        private void FiltrarHistorialPorTipoEntrega()
        {
            string tipoEntregaSeleccionado = cmbTipoEntrega.SelectedItem.ToString();

            if (tipoEntregaSeleccionado == "Todos")
            {
                CargarHistorial();
            }
            else
            {
                List<Pedido> pedidosFiltrados = RegistroPedidos.Instancia.ObtenerPedido()
                    .Where(p => p.MetodoEntrega.TipoEntrega() == tipoEntregaSeleccionado)
                    .ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Cliente", typeof(string));
                dt.Columns.Add("Producto", typeof(string));
                dt.Columns.Add("Tipo de Entrega", typeof(string));
                dt.Columns.Add("Costo de Entrega", typeof(string));
                foreach (Pedido pedido in pedidosFiltrados)
                {
                    dt.Rows.Add(pedido.Cliente, pedido.Producto, pedido.MetodoEntrega.TipoEntrega(), $"${pedido.ObtenerCosto():N2}");
                }

                dgvHistorial.DataSource = dt;
            }

        }

        private void cmbTipoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarHistorialPorTipoEntrega();
        }
    }
}
