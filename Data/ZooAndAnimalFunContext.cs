using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZooAnimalList.Models;
using ZooAndAnimalFun.Models;

namespace ZooAndAnimalFun.Data
{
    public class ZooAndAnimalFunContext : DbContext
    {
        public ZooAndAnimalFunContext (DbContextOptions<ZooAndAnimalFunContext> options)
            : base(options)
        {
        }

        public DbSet<ZooAnimalList.Models.Animal> Animal { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.AnimalCategories> AnimalCategories { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.Customer> Customer { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.Employee> Employee { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.Event> Event { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.EventCategory> EventCategory { get; set; } = default!;
        public DbSet<ZooAndAnimalFun.Models.Gender> Gender { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.HealthStatus> HealthStatus { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.Session> Session { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.Species> Species { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.TicketSales> TicketSales { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.TicketType> TicketType { get; set; } = default!;
        public DbSet<ZooAnimalList.Models.Venue> Venue { get; set; } = default!;
    }
}
