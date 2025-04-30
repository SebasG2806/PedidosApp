using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{
    public sealed class RegistroPedidos
    {
        private static RegistroPedidos _Instancia = null;
        private static readonly object _lock = new object();
        public List<Pedido> Pedidos { get; private set; }
        private RegistroPedidos()
        {
            Pedidos = new List<Pedido>();
        }
        public static RegistroPedidos Instancia
        {
            get
            {
                if(_Instancia == null)
                {
                    lock (_lock)
                    {
                        if(_Instancia == null)
                        {
                            _Instancia = new RegistroPedidos();
                        }
                    }
                }
                return _Instancia;
            }
        }
        public void AgregarPedido(Pedido pedido)
        {
            if(pedido != null)
            {
                Pedidos.Add(pedido);
            }
        }

        public List<Pedido> ObtenerPedido()
        {
            return Pedidos; 
        }

        public List<string> ObtenerTiposEntrega()
        {
            return Pedidos.Select(p => p.MetodoEntrega.TipoEntrega()).Distinct().ToList();
        }
    }
}
