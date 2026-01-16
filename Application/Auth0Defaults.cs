using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;



namespace AdminApp.Application
{
    public class Auth0Defaults 
    {
        public  const string AuthenticationScheme = "Auth0";
        public const string ClaimsIssuer = "Auth0";

        public static readonly string CallbackPath = new PathString("/callback");
    }
}