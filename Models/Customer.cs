using System;
using System.ComponentModel.DataAnnotations;
using CustomerManagementASPNETCoreMVC.Models.Enums;

namespace CustomerManagementASPNETCoreMVC.Models;

public class Customer
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    public CustomerType CustomerType { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
