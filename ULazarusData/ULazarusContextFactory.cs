using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ULazarusData
{
    public class ULazarusContextFactory : IDesignTimeDbContextFactory<ULazarusContext>
    {
        public ULazarusContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ULazarusContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ULazarus;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ULazarusContext(optionsBuilder.Options);
        }
    }
}

