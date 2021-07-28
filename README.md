# Myxy.NET

### **References** :

> > [i3yuan](https://www.cnblogs.com/i3yuan/p/13843082.html)  
> > [How To Use ASP.NET Identity And IdentityServer4 In Your Solution](https://feras.blog/how-to-use-asp-net-identity-and-identityserver4-in-your-solution/)

### **Configurations** :

    1. Identity service: https://localhost:8001

    2. Web Client: https://localhost:8002

    3. Tools: https://jwt.ms/

#

---

### **Migrations Commands** :

#### dotnet ef migrations add InitialIdentityServerPersistedGrantDbMigration -c PersistedGrantDbContext -o Data/Migrations/PersistedGrantDb

#### dotnet ef migrations add InitialIdentityServerConfigurationDbMigration -c ConfigurationDbContext -o Data/Migrations/ConfigurationDb

---

### **Update Commands** :

#### update-database -c PersistedGrantDbContext

#### update-database -c ConfigurationDbContext
