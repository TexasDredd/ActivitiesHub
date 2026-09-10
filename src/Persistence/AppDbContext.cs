using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace Persistence;
 public class AppDbContext(DbContextOptions options) : DbContext (options)
{
    public DbSet<Domain.Activity> Activities { get; set; }

}
