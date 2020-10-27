using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InvoiceManagementBlazor.Client.helpers
{
    public class HttpResponseWraper<T>
    {
        public HttpResponseWraper(T _Response, bool success, HttpResponseMessage httpResponseMessage)
        {
            IsSuccess = success;
            Response = _Response;
            response = httpResponseMessage;
        }

        public bool IsSuccess { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage response { get; set; }
    }
}
