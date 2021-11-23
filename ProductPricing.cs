using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_Pricing
{
    public class ProductPricing
    {
        public decimal Pricing(string product)
        {
            if (String.IsNullOrEmpty(product))
            {
                return 0;
            }

            return -1;

        }

    }
}
