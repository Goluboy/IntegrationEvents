using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationEvents;

public static class Topics
{
    public static class Orders
    {
        public const string Created = "orders.created";
        public const string Cancelled = "orders.cancelled";

        public const string SagaTimeout = "orders.saga-timeout";
    }

    public static class Products
    {
        public const string StockReserved = "products.stock.reserved";
        public const string StockFailed = "products.stock.failed";
    }

    public static class Prices
    {
        public const string Calculated = "prices.calculated";
    }
}