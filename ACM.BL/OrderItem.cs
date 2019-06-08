using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class OrderItem
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }


        public OrderItem Retrieve()
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
            // Validation code
            return true;
        }
    
    }
}
