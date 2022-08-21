using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFcfa
{
    public partial class SampleModel : DbContext
    {
        public SampleModel()
            : base("name=SampleMod")
        {
        }
        public DbSet <Sample> Samples { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
