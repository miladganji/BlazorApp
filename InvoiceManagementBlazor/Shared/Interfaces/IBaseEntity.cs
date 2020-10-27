using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementBlazor.Shared.Interfaces
{
  public  interface IBaseEntity<T>
    {
        public T Id { get; set; }
    }
}
