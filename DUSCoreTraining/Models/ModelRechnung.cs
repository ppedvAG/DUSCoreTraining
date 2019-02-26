using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DUSCoreTraining.Models
{
    public class ModelRechnung:DbContext
    {
        public ModelRechnung(DbContextOptions<ModelRechnung> options):base(options)
        {

        }
        public virtual DbSet<Rechnung> Rechnungs { get; set; }
        public virtual DbSet<Positionen> Positionens { get; set; }

        //Obsolet EF Core -> per DBCOntext Options Startup.cs
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;AttachDbFilename=c:\\aspnetcore\\training\\DUSCoreTraining\\DUSCoreTraining\\wwwroot\\app_data\\rechnung3.mdf;database=rechnung3;Integrated Security=True; MultipleActiveResultSets=True");
        //    //optionsBuilder.UseSqlServer(new ConfigurationBuilder().GetConnectionString("Rechnung"));
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
