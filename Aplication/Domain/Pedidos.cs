using System;

namespace Application.Services
{
    public class Pedidos
    {
        public Guid Id { get; set; }

        public decimal Total { get; set; }

        public int Quantidade { get; set; }

        public Guid ClienteID { get; set; }
    }
}