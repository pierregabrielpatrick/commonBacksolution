using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dal.context
{
    public class CommonContext : DbContext
    {

        public DbSet<HouseModel> houseModels;

        //public void Configure(EntityTypeBuilder<CommonContext> builder)
        //{
        //    builder
        //        .Property(b => b.Url)
        //        .IsRequired();
        //}

        public CommonContext(DbContextOptions<CommonContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommonContext).Assembly);
        }
    }
}
}
