using Oflow_app_Server.Services.Base;

namespace Oflow_app_Server.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();

    }


}

