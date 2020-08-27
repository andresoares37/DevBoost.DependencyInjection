using Application.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public interface IClienteService
    {
        void Add(Cliente cliente);
        List<Cliente> Get();
    }
}
