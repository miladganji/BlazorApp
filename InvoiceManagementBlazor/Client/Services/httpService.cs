using InvoiceManagementBlazor.Client.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InvoiceManagementBlazor.Client.Services
{
    public class httpService : IhttpService
    {
        private readonly HttpClient httpClient;

        public httpService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<HttpResponseWraper<object>> Post(string url, object data)
        {
            var jsondata = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);
            return new HttpResponseWraper<object>(null, response.IsSuccessStatusCode, response);
        }
    }
}
