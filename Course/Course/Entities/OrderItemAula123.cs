using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class OrderItemAula123
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public ProductAula123 Product { get; set; } 

        public OrderItemAula123()
        {
        }

        public OrderItemAula123(int quantity, double price, ProductAula123 product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal()
        {
            return this.Quantity * this.Price;
        }
    }
}
