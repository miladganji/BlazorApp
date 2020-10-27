using InvoiceManagementBlazor.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementBlazor.Shared.Entities
{
    public class Food : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public string  FoodName { get; set; }
        public decimal Price { get; set; }
        public DateTime  CreatedDate{ get; set; }
    }

}
