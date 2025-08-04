using System;
using System.ComponentModel.DataAnnotations;
using CustomerManagementASPNETCoreMVC.Models.Enums;

namespace CustomerManagementASPNETCoreMVC.Models;

public class Order
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    [DataType(DataType.Currency)]
    [Display(Name = "Total Order")]
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }

    public OrderStatus Status { get; set; }
    public string? Notes { get; set; }

    [Display(Name = "Customer")]
    public int CustomerId { get; set; }
    public virtual Customer? Customer { get; set; }

    [Display(Name = "Product")]
    public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
}
