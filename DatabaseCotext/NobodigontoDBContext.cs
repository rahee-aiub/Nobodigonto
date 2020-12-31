using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCoreApp.Models;

namespace TestCoreApp.DatabaseCotext
{
    public class NobodigontoDBContext : DbContext
    {
        public NobodigontoDBContext(DbContextOptions<NobodigontoDBContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Member> members { get; set; }
    }
}
