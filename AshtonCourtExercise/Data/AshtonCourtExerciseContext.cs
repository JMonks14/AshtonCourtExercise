using AshtonCourtExercise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AshtonCourtExercise.Data
{
    public class AshtonCourtExerciseContext : DbContext
    {
        public AshtonCourtExerciseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarSale> Sales { get; set; }
    }
}
