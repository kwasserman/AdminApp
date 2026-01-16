using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop.Infrastructure;

namespace AdminApp.Application
{
    public static class Auth0Extensions
    {
        public static AuthenticationBuilder AddAuth0(this AuthenticationBuilder builder, Action<Auth0Options> configureOptions)
        {
            return builder.AddAuth0(Auth0Defaults.AuthenticationScheme, configureOptions);
        }

        public static AuthenticationBuilder AddAuth0(this AuthenticationBuilder builder, string authenticationScheme, Action<Auth0Options> configureOptions)
        {
            var auth0options = new Auth0Options();

            configureOptions(auth0options);

            return builder.AddOpenIdConnect(authenticationScheme, options  =>
            {
                options.Authority = $"https://{auth0options.Domain}/";
                options.ClientId = auth0options.ClientId;
                options.ClientSecret = auth0options.ClientSecret;
                options.ResponseType = "code";
                options.Scope.Clear();
                foreach (var scope in auth0options.Scope)
                {
                    options.Scope.Add(scope);
                }
                options.SaveTokens = auth0options.SaveTokens;
                options.CallbackPath = auth0options.CallbackPath;
                options.ClaimsIssuer = auth0options.ClaimsIssuer;

                options.TokenValidationParameters = auth0options.TokenValidationParameters;

                options.Events = new OpenIdConnectEvents
                {   
                    OnRedirectToIdentityProviderForSignOut = context =>
                    {
                        var logoutUri = $"{options.Authority}/v2/logout?client_id={options.ClientId}";
                        
                        var postLogoutUri = context.Properties.RedirectUri;
                        if (!string.IsNullOrEmpty(postLogoutUri))
                        {
                            if (postLogoutUri.StartsWith("/"))
                            {
                                var request = context.Request;
                                postLogoutUri = request.Scheme + "://" + request.Host + request.PathBase + postLogoutUri;
                            }
                            logoutUri += $"&returnTo={Uri.EscapeDataString(postLogoutUri)}";
                        }
                        
                        context.Response.Redirect(logoutUri);
                        context.HandleResponse();
                        
                        return Task.CompletedTask;
                    }
                };
            });
        }
    }
}
