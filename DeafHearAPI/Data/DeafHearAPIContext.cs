using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeafHearAPI.Models;

namespace DeafHearAPI.Data
{
    public class DeafHearAPIContext : DbContext
    {
        public DeafHearAPIContext (DbContextOptions<DeafHearAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DeafHearAPI.Models.User> User { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=DeafHearAPIContext-1be11bae-0a30-41de-b30c-02aecf581ea6;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
