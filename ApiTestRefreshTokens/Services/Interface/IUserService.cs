using ApiTestRefreshTokens.Entities;
using ApiTestRefreshTokens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTestRefreshTokens.Services.Interface
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<AppUser> GetAll();
        AppUser GetById(int id);
    }
}
