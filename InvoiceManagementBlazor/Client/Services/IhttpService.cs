using InvoiceManagementBlazor.Client.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagementBlazor.Client.Services
{
   public interface IhttpService
    {
        Task<HttpResponseWraper<object>> Post(string url, object data);
    }
}
