using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{
    public static class EntregaFactory
    {
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {
            if(tipoProducto.ToLower()== "tecnologia" && urgente)
            {
                return new EntregaDron();
            } else if(tipoProducto.ToLower() == "accesorio")
            {
                return new EntregaMoto();
            }else if(tipoProducto.ToLower() == "componente" || peso > 10)
            {
                return new EntregaCamion();
            }
            else
            {
                return new EntregaMoto();
            }
        }
    }
}
