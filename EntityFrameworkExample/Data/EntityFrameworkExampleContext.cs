using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkExample.Models;

namespace EntityFrameworkExample.Data
{
    public class EntityFrameworkExampleContext : DbContext
    {
        public EntityFrameworkExampleContext (DbContextOptions<EntityFrameworkExampleContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameworkExample.Models.Customer> Customer { get; set; } = default!;
    }
}
