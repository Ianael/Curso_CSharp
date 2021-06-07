using System;
using System.Collections.Generic;
using System.Text;
using Pedidos.Entities.Enums;

namespace Pedidos.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client{ get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) { 
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double sum = 0.0;
            foreach (OrderItem x in Items) {
                sum += x.SubTotal();
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARRY: ");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email} ");
            sb.AppendLine("Order items: ");
            foreach (OrderItem x in Items) {
                sb.AppendLine(x.ToString());
            }
            sb.AppendLine($"Total price: ${Total().ToString()}: ");
            
            return sb.ToString();
        }
    }
}
