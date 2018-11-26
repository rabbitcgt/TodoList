using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace voting
{
    public class VotingContext : DbContext
    {
        public VotingContext(DbContextOptions<VotingContext> options)
            : base(options)
        { }

        public DbSet<Person> People { get; set; }
    }

    public class Person
    {
        public int PersonID { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }
    }
}