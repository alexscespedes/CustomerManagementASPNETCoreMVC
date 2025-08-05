using System;
using CustomerManagementASPNETCoreMVC.Models;

namespace CustomerManagementASPNETCoreMVC.Data;

public static class DbInitializer
{
    public static void Seed(AppDbContext context)
    {
        if (context.Customers.Any() || context.Products.Any() || context.Orders.Any())
            return;

        var customers = new List<Customer>
        {
            new Customer {Name = "Alexander Sencion", CustomerType = Models.Enums.CustomerType.Regular},
            new Customer {Name = "Damon Salvatore", CustomerType = Models.Enums.CustomerType.Premiun},
            new Customer {Name = "Chris Paul", CustomerType = Models.Enums.CustomerType.VIP},
        };

        var products = new List<Product>
        {
            new Product {Name = "Laptop Dell Inspiron", Price = 1500, StockQuantity = 15},
            new Product {Name = "Headphones Sony", Price = 625, StockQuantity = 37},
            new Product {Name = "Keyboard Logitech", Price = 178, StockQuantity = 65},
        };

        context.Customers.AddRange(customers);
        context.Products.AddRange(products);
        context.SaveChanges();

        var orders = new List<Order>
        {
            new Order { Quantity = 1, CustomerId = customers[0].Id, ProductId = products[0].Id, TotalAmount = 1350, Status = Models.Enums.OrderStatus.Pending, OrderDate = new DateTime(2025, 07, 28)},
            new Order { Quantity = 2, CustomerId = customers[1].Id, ProductId = products[1].Id, TotalAmount = 819, Status = Models.Enums.OrderStatus.Processing, OrderDate = new DateTime(2025, 07, 28)},
            new Order { Quantity = 3, CustomerId = customers[2].Id, ProductId = products[2].Id, TotalAmount = 750, Status = Models.Enums.OrderStatus.Delivered, OrderDate = new DateTime(2025, 07, 28)}
        };

        context.Orders.AddRange(orders);
        context.SaveChanges();
    }
}
