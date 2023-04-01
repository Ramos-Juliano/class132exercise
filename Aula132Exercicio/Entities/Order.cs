using Class132.Entities.Enums;
using CLass132Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class132Exercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client CLient { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        
    }
}
