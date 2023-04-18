using Fiap.Api.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Fiap.Api.AspNet.Repository.Context
{
    public class DataBaseContext : DbContext
    {
        public virtual DbSet<RioModel> Rio { get; set; }
        public virtual DbSet<AreaDeRiscoModel> AreaDeRisco { get; set; }
        public virtual DbSet<BoiaModel> Boia { get; set; }
        public virtual DbSet<PluviometroModel> Pluviometro { get; set; }

        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        protected DataBaseContext()
        {

        }

    }
}