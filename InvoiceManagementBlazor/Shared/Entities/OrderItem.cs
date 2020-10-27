using InvoiceManagementBlazor.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementBlazor.Shared.Entities
{
   public class OrderItem:IBaseEntity<Guid>
    {
       
        
        public Guid Id { get; set; }

        public int qty { get; set; }
        public  Food Food { get; set; }
    }
}
