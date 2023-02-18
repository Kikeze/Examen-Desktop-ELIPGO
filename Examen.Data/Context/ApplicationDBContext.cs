using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen.Data.Models;

namespace Examen.Data.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
            // Do nothing
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
