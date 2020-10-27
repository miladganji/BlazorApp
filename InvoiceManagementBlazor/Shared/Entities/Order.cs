using InvoiceManagementBlazor.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementBlazor.Shared.Entities
{
    public class Order : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Tax { get; set; }
        public int Amount { get; set; }
        public List<OrderItem> OrderItem { get; set; }
        public User User { get; set; }
    }
}
