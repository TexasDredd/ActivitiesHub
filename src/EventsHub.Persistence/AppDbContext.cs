using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using EventsHub.Domain;


namespace EventsHub.Persistence;
 public class AppDbContext(DbContextOptions options) : DbContext (options)
{
    public DbSet<Event> Events { get; set; }

}
