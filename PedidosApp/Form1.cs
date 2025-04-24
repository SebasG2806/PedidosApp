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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }
            if(cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un tipo de producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProducto.Focus();
                return;
            }
            try
            {
                string cliente = txtCliente.Text;
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nupPeso.Value);
                int distancia = Convert.ToInt32(nupDistancia.Value);
                Pedido nuevoPedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(nuevoPedido);

                lblResultado.Text = $"Cliente: {nuevoPedido.Cliente}\n" +
                                    $"Producto: {nuevoPedido.Producto}\n" +
                                    $"Entrega Seleccionada: {nuevoPedido.MetodoEntrega.TipoEntrega()}\n" +
                                    $"Costo de Entrega: ${nuevoPedido.ObtenerCosto():N2}";
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
