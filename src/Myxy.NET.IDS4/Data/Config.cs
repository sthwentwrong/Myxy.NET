// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Myxy.NET.IDS4.Data
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
                new ApiScope("openid"),
                new ApiScope("profile"),
                new ApiScope("email"),
                new ApiScope("read"),
                new ApiScope("write"),
                new ApiScope("identity-server-demo-api"),
                new ApiScope("code_scope1"),
            };

        public static IEnumerable<ApiResource> ApiResources => 
            new ApiResource[]
            {
                new ApiResource
                {
                    Name = "identity-server-demo-api",
                    DisplayName = "Identity Server Demo API",
                    Scopes = new List<string>
                    {
                        "write",
                        "read"
                    }
                },
                new ApiResource("api1","api1")
                {
                    Scopes={ "code_scope1" },
                    UserClaims={JwtClaimTypes.Role},  //添加Cliam 角色类型
                    ApiSecrets={new Secret("apipwd".Sha256())}
                },
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "code_client",
                    ClientName = "code Auth",

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris ={
                    "http://localhost:6003/signin-oidc", //跳转登录到的客户端的地址
                    },
                    // RedirectUris = {"http://localhost:6003/auth.html" }, //跳转登出到的客户端的地址
                    PostLogoutRedirectUris ={
                        "http://localhost:6003/signout-callback-oidc",
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
                    ClientId = "identity-server-demo-web",
                    AllowedGrantTypes = new List<string> { GrantType.AuthorizationCode },
                    RequireClientSecret = false,
                    RequireConsent = false,
                    RedirectUris = new List<string> { "http://localhost:3006/signin-callback.html" },
                    PostLogoutRedirectUris = new List<string> { "http://localhost:3006/" },
                    AllowedScopes = { "identity-server-demo-api", "write", "read", "openid", "profile", "email" },
                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:3006",
                    },
                    AccessTokenLifetime = 86400
                },
            };
    }
}