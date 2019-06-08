using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double CurrentPrice { get; set; }
        

        public Product Retrieve()
        {
            // retrieval code
            return new Product();
        }

        public bool Save()
        {
            // saving code
            return true;
        }

        public bool Validate()
        {
            // Validation code
            return true;
        }
    }
}
