using Application.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ClienteService : IClienteService
    {
        List<Cliente> Clientes = new List<Cliente>();

        public void Add(Cliente cliente)
        {
            cliente.Id = Guid.NewGuid();
            Clientes.Add(cliente);
        }

        public List<Cliente> Get()
        {
            return Clientes;
        }
    }
}
