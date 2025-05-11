using System;
using System.Collections.Generic;

namespace InventoryManagementAPI.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int? ProductId { get; set; }
        public string TransactionType { get; set; } = null!;
        public int Quantity { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? Notes { get; set; }

        public virtual Product? Product { get; set; }
    }
}
