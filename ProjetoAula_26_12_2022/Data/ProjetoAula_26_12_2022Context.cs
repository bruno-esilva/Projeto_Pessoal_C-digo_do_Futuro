using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoAula_26_12_2022.Models;

namespace ProjetoAula_26_12_2022.Data
{
    public class ProjetoAula_26_12_2022Context : DbContext
    {
        public ProjetoAula_26_12_2022Context (DbContextOptions<ProjetoAula_26_12_2022Context> options)
            : base(options)
        {
        }

        public DbSet<ProjetoAula_26_12_2022.Models.Produto> Produto { get; set; } = default!;

    }
}
