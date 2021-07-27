// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Myxy.NET.IdS4
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("scope1"),
                new ApiScope("scope2"),
                new ApiScope("code_scope1"),
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {

                new ApiResource("api1","api1")
                {
                    Scopes={ "code_scope1" },
                    UserClaims={JwtClaimTypes.Role},
                    ApiSecrets={new Secret("apipwd".Sha256())}
                }
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "code_client2",
                    ClientName = "code Auth 5002",

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris ={
                    "http://localhost:5002/signin-oidc", //跳转登录到的客户端的地址
                    },
                    // RedirectUris = {"http://localhost:8002/auth.html" }, //跳转登出到的客户端的地址
                    PostLogoutRedirectUris ={
                        "http://localhost:5002/signout-callback-oidc",
                    },
                    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "code_scope1"
                    },
                    //允许将token通过浏览器传递
                    AllowAccessTokensViaBrowser=true,
                    // 是否需要同意授权 （默认是false）
                    RequireConsent=true
                 },
                new Client
                {
                    ClientId = "code_client",
                    ClientName = "code Auth",

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris ={
                    "https://localhost:8002/signin-oidc", //跳转登录到的客户端的地址
                    },
                    // RedirectUris = {"http://localhost:8002/auth.html" }, //跳转登出到的客户端的地址
                    PostLogoutRedirectUris ={
                        "https://localhost:8002/signout-callback-oidc",
                    },
                    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "code_scope1"
                    },
                    //允许将token通过浏览器传递
                    AllowAccessTokensViaBrowser=true,
                    // 是否需要同意授权 （默认是false）
                    RequireConsent=true
                 },
                // m2m client credentials flow client
                new Client
                {
                    ClientId = "m2m.client",
                    ClientName = "Client Credentials Client",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

                    AllowedScopes = { "scope1" }
                },

                // interactive client using code flow + pkce
                new Client
                {
                    ClientId = "interactive",
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { "https://localhost:44300/signin-oidc" },
                    FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "scope2" }
                },
            };
    }
}