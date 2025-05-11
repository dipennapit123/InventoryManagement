using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            Inventories = new HashSet<Inventory>();
            OrderItems = new HashSet<OrderItem>();
            Transactions = new HashSet<Transaction>();
        }
    
        
        public int ProductId { get; set; }
        
        [Required] 
        public string ProductName { get; set; } = null!;
        
        [Required]
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        
        [Required]
        public decimal UnitPrice { get; set; }
        public string? Description { get; set; }
        public string? Sku { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
