using System;
using System.Collections.Generic;

namespace CampusCafeOrderingSystem
{
    // --- Core Service ---
    public class OrderService
    {
        public OrderService(IProductCatalogue catalogue, IPricingPolicy pricingPolicy)
        {
            throw new NotImplementedException();
        }

        public OrderSummary ProcessOrder(IReadOnlyList<OrderLine> lines)
        {
            throw new NotImplementedException();
        }
    }

    // --- Main Program ---
    public class Program
    {
        public static void Main()
        {
            throw new NotImplementedException();
        }
    }
}