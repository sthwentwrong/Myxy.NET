// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityService
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                // You may add other identity resources like address,phone... etc
                //new IdentityResources.Address()
            };

        // Block 1: All APIs, I want to protect in my system
        public static IEnumerable<ApiResource> GetApis=>
             new ApiResource[]
            {
                new ApiResource("identity.api", "Identity API"),
                new ApiResource("test.api","Test API")
            };


        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("scope1"),
                new ApiScope("scope2"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                //Block 2:  MVC client using hybrid flow
                new Client
                {
                    ClientId = "webclient",
                    ClientName = "Web Client",
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    RedirectUris = { "https://localhost:5001/signin-oidc" },
                    FrontChannelLogoutUri = "https://localhost:5001/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:5001/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "identity.api","test.api" }
                },
                new Client
                { 
                    ClientId="webapiclient",
                    ClientName= "WebApi Client",
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("Secrets".Sha256()) },
                    AllowedScopes = { "scope1" }
                }
            };
    }
}