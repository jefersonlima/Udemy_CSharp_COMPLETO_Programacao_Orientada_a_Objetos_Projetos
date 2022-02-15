using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class OrderAula123
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItemAula123> OrderItems { get; set; } = new List<OrderItemAula123>();
        public ClientAula123 Client { get; set; }

        public OrderAula123()
        {
        }

        public OrderAula123(DateTime moment, OrderStatus status, ClientAula123 client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
        }

        public void AddItem(OrderItemAula123 item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItemAula123 item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (var item in OrderItems)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("ORDER SUMARY:");

            sb.Append("Order moment: ");
            sb.AppendLine(this.Moment.ToString("dd/MM/yyyy HH:mm:ss"));

            sb.Append("Order status: ");
            sb.AppendLine(this.Status.ToString());

            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(this.Client.Email.ToString());

            if (OrderItems.Count > 0)
            {
                sb.AppendLine("Order Items:");
                foreach (var item in OrderItems)
                {
                    sb.Append(item.Product.Name);
                    sb.Append(", $");
                    sb.Append(item.Product.Price.ToString("F2", CultureInfo.InvariantCulture));
                    sb.Append(", Quantity: ");
                    sb.Append(item.Quantity);
                    sb.Append(", SubTotal: $");
                    sb.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                }
                sb.Append("Total price: $");
                sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}
