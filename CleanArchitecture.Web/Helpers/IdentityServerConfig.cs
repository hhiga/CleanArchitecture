using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.Helpers
{
    public static class IdentityServerConfig
    {
        public static IEnumerable<ApiResource> GetApis() =>
            new List<ApiResource>
            {
                new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
            };

        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource>
            {
                new IdentityResources.Profile(),
                new IdentityResources.OpenId()
            };

        public static IEnumerable<Client> GetClients() =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "angular-app",
                    ClientName = "Angular app",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce  = true,
                    RequireClientSecret = false,
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.LocalApi.ScopeName
                    },
                    RedirectUris = { "http://localhost:4200/auth-callback" },
                    AllowedCorsOrigins = { "http://localhost:4200" },
                    PostLogoutRedirectUris = { "http://localhost:4200" },
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false
                }
            };
    }
}
