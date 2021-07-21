using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Myxy.NET;

namespace Myxy.NET.Data
{
    public class MyxyNETContext : DbContext
    {
        public MyxyNETContext(DbContextOptions<MyxyNETContext> options)
            : base(options)
        {
        }

        public DbSet<Myxy.NET.AzDO> AzDO { get; set; }
        public DbSet<Myxy.NET.E2EOnWindows> E2EOnWindows { get; set; }
        public DbSet<Myxy.NET.E2EOnMac> E2EOnMac { get; set; }
        public DbSet<Myxy.NET.E2EOnLinux> E2EOnLinux { get; set; }
    }
}
