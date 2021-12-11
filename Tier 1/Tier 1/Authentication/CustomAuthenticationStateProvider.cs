using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using Tier_1.Data.ClientService;
using Tier_1.Models.Client;

namespace Tier_1.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IClientService _clientService;
        public Client CachedUser { get; set; }

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IClientService clientService)
        {
            _jsRuntime = jsRuntime;
            _clientService = clientService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (CachedUser == null)
            {
                string userAsJson = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    CachedUser = JsonSerializer.Deserialize<Client>(userAsJson);

                    identity = SetupClaimsForUser(CachedUser);
                }
            }
            else
            {
                identity = SetupClaimsForUser(CachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }
        
        public async Task<Client> ValidateLogin(Client client)
        {
            Client user;
            Console.WriteLine("Validating log in");
            if (string.IsNullOrEmpty(client.Username)) throw new Exception("Enter Username");
            Console.WriteLine("Validating log in");

            if (string.IsNullOrEmpty(client.Password)) throw new Exception("Enter password");
            Console.WriteLine("Validating log in");

            ClaimsIdentity identity = new ClaimsIdentity();
            Console.WriteLine("Validating log in");

           try
           {
                user = await _clientService.ValidateClient(client);
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                identity = SetupClaimsForUser(user);
                string serialisedData = JsonSerializer.Serialize(user);
                Console.WriteLine("before data send");
                await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
                Console.WriteLine("data sent");
                CachedUser = user;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
               throw e;
           }

            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
            return CachedUser;
            
           
         /*  Client client1 = await _clientService.ValidateClient(client);
           Console.WriteLine("Validating log in");

           identity = SetupClaimsForUser(client1);
           Console.WriteLine("Validating log in");

           string serialisedData = JsonSerializer.Serialize(client1);
           Console.WriteLine($"Serialized data: {serialisedData}");
           await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
           Console.WriteLine("after jsRuntime");
           CachedUser = client1;

           NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
           */
        }
        
        public void Logout()
        {
            CachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        
        private ClaimsIdentity SetupClaimsForUser(Client user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim("ClientId", user.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, user.Name));
            claims.Add(new Claim("Username", user.Username));
            claims.Add(new Claim("Password", user.Password));



            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}