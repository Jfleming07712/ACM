using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Order
    {
        public int OrderDate { get; set; }


        public Order Receive()
        {
            // retrieval code
            return new Order();
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
