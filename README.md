# myxy
### Reference: https://feras.blog/how-to-use-asp-net-identity-and-identityserver4-in-your-solution/
### Reference: https://www.cnblogs.com/i3yuan/p/13843082.html
## Identity service: https://localhost:5000
## WebApiClient: https://localhost:5001
### Tools: https://jwt.ms/

# --------------------------------------------------------------------------
## dotnet ef migrations add InitialIdentityServerPersistedGrantDbMigration -c PersistedGrantDbContext -o Data/Migrations/PersistedGrantDb
## dotnet ef migrations add InitialIdentityServerConfigurationDbMigration -c ConfigurationDbContext -o Data/Migrations/ConfigurationDb
### update-database -c PersistedGrantDbContext 
### update-database -c ConfigurationDbContext