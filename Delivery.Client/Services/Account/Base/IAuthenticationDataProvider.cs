using Delivery.Application.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Client.Services.Account.Base
{
    public interface IAuthenticationDataProvider
    {
        Task RegisterUser(RegisterUserModel userForRegistration);

        Task LoginUser(LoginUserModel userForLogin);

        Task UpdateUser(EditUserModel userForEdit);

        Task DeleteUser(string userId);
    }
}
