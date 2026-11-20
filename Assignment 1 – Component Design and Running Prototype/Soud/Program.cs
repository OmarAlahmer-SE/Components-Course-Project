using System;

namespace CampusCafeOrderingSystem
{
    // --- Mandatory Interface ---
    public interface IReceiptFormatter
    {
        string Format(OrderSummary summary);
    }

    // --- Implementation (Checkpoint 1) ---
    public class DetailedReceiptFormatter : IReceiptFormatter
    {
        public string Format(OrderSummary summary)
        {
            throw new NotImplementedException();
        }
    }

    // --- Test Runner Helper ---
    public static class TestRunner
    {
        public static void RunAllTests()
        {
            throw new NotImplementedException();
        }

        private static void RunT01_ValidOrderNoDiscount()
        {
            throw new NotImplementedException();
        }

        private static void RunT04_EmptyOrder_ThrowsArgumentException()
        {
            throw new NotImplementedException();
        }

        private static void RunT06_ZeroQuantity_ThrowsArgumentException()
        {
            throw new NotImplementedException();
        }
    }
}