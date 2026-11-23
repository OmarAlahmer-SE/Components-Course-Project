using System;
using System.Collections.Generic;

namespace CampusCafeOrderingSystem
{
    // --- Mandatory Interface ---
    public interface IProductCatalogue
    {
        Product GetById(string productId);
    }

    // --- Data Models ---
    public class Product
    {
        public string Id { get; }
        public string Name { get; }
        public decimal UnitPrice { get; }

        public Product(string id, string name, decimal unitPrice)
        {
            throw new NotImplementedException();
        }
    }

    public class OrderLine
    {
        public string ProductId { get; }
        public int Quantity { get; }

        public OrderLine(string productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }

    public class CalculatedLine
    {
        public string ProductId { get; }
        public string ProductName { get; }
        public int Quantity { get; }
        public decimal UnitPrice { get; }
        public decimal LineTotal { get; }

        public CalculatedLine(string productId, string productName, int quantity, decimal unitPrice, decimal lineTotal)
        {
            throw new NotImplementedException();
        }
    }

    public class OrderSummary
    {
        public IReadOnlyList<CalculatedLine> Lines { get; }
        public string PolicyName { get; }
        public decimal Subtotal { get; }
        public decimal DiscountAmount { get; }
        public decimal FinalTotal { get; }

        public OrderSummary(IReadOnlyList<CalculatedLine> lines, string policyName, decimal subtotal, decimal discountAmount, decimal finalTotal)
        {
            throw new NotImplementedException();
        }
    }

    // --- Implementation ---
    public class InMemoryCatalogue : IProductCatalogue
    {
        public InMemoryCatalogue()
        {
            throw new NotImplementedException();
        }

        public Product GetById(string productId)
        {
            throw new NotImplementedException();
        }
    }
}