using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZooAndAnimalFun.Models;
using ZooAndAnimalFun.Models;

namespace ZooAndAnimalFun.Data
{
    public class ZooAndAnimalFunContext : DbContext
    {
        public ZooAndAnimalFunContext (DbContextOptions<ZooAndAnimalFunContext> options)
            : base(options)
        {
        }

        public DbSet<ZooAndAnimalFun.Models.Animal> Animal { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.AnimalCategories> AnimalCategories { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.Customer> Customer { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.Employee> Employee { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.Event> Event { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.EventCategory> EventCategory { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.Gender> Gender { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.HealthStatus> HealthStatus { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.Session> Session { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.Species> Species { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.TicketSales> TicketSales { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.TicketType> TicketType { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.Venue> Venue { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Event>()

                .HasOne(e => e.EventCategory)

                .WithMany()

                .HasForeignKey(e => e.EventCategoryID)

                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Session>()

                .HasOne(s => s.Venue)

                .WithMany()

                .HasForeignKey(s => s.VenueID)

                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}


