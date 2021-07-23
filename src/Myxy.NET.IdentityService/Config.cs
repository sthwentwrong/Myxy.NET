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

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("client_scope1"),
            };

        public static IEnumerable<ApiResource> GetApiResourcess =>
             new ApiResource[]
            {
                new ApiResource("api1", "Identity API"){
                    Scopes={ "client_scope1" }
                },
            };


        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client{
                    ClientId = "credentials_client",
                    ClientName = "Client Credentials Client",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256())},

                    AllowedScopes = { "client_scope1" }
                },
            };
    }
}