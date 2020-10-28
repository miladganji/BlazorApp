using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InvoiceManagementBlazor.Client.auth
{
    public class DummyAuthenticationProvider : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(3000);
            var Identity = new ClaimsIdentity(new List<Claim>() { 
            new Claim(ClaimTypes.Name,"milad")
           
            
            },"test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(Identity)));
        }
    }
}
