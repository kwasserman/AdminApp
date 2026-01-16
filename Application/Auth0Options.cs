using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;


namespace AdminApp.Application
{
    public class Auth0Options : OpenIdConnectOptions
    {
        public string Domain { get; set; }

        public Auth0Options()
        {
            ResponseType = OpenIdConnectResponseType.Code;

            Scope.Clear();
            Scope.Add("openid");
            Scope.Add("profile");
            Scope.Add("email");

            CallbackPath = Auth0Defaults.CallbackPath;
            ClaimsIssuer = Auth0Defaults.ClaimsIssuer;
            SaveTokens = true;

            TokenValidationParameters = new TokenValidationParameters
            {
                NameClaimType = "name",
                
            };

        }
    }
}
