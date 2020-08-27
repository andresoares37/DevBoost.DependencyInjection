using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PedidoService : IPedidoService
    {
        List<Pedidos> Pedidos = new List<Pedidos>();
        public void Add(Pedidos pedidos)
        {
            Pedidos.Add(pedidos);
        }
    }
}
