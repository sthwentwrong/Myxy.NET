using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myxy.NET
{
    public class MyxyContext : DbContext
    {
        public MyxyContext(DbContextOptions<MyxyContext> options)
            : base(options)
        {
        }

        public DbSet<AzDOMetadata> AzDOMetadata { get; set; }
    }
}
