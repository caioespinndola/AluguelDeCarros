using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarros.Data
{
    public class AluguelDeCarrosContext : DbContext
    {
        public AluguelDeCarrosContext (DbContextOptions<AluguelDeCarrosContext> options)
            : base(options)
        {
        }

        public DbSet<Carro> Carro { get; set; } = default!;
        public DbSet<Aluguel> Aluguel { get; set; } = default!;
        public DbSet<Cliente> Cliente { get; set; } = default!;
    }
}
