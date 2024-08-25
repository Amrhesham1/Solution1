using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Oflow_app_Server.Providers;
using Oflow_app_Server.Services.Base;

namespace Oflow_app_Server.Services.Authentication
{
    public class AuthenticationServices : IAuthenticationService
    {

        private readonly IClient httpClient;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationServices(IClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            this.httpClient = httpClient;


            this.localStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }


        public async Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            var response = await httpClient.LoginAsync(loginModel);


            await localStorage.SetItemAsync("accessToken", response.Token);
            ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedIn();


            return true;

        }

    

        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedOut();

        }

    }
}
