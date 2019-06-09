using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
           OrderItemId = orderItemId;
        }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int OrderItemId { get; private set; }


        public OrderItem Retrieve(int orderItemId)
        {
            // Retrieval code
            return new OrderItem();
        }

        public bool Save()
        {
            // Saving code
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    
    }
}
