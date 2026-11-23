using System;

namespace CampusCafeOrderingSystem
{
    // --- Mandatory Interface ---
    public interface IPricingPolicy
    {
        string Name { get; }
        decimal Apply(decimal subtotal);
    }

    // --- Implementation (Checkpoint 1) ---
    public class NoDiscount : IPricingPolicy
    {
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Apply(decimal subtotal)
        {
            throw new NotImplementedException();
        }
    }
}