using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnesCentre_lab_2_2.Models
{
    public class FitnesCentreContext : DbContext
    {
        public virtual DbSet<Buy_subscription> Buy_subscription { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Scedule> Scedule { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }
        public virtual DbSet<User> User { get; set; }

        public FitnesCentreContext(DbContextOptions<FitnesCentreContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
