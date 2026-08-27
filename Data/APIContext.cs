using Microsoft.EntityFrameworkCore;
using SQLiteAPI.Models;

namespace SQLiteAPI.Data;

public class APIContext : DbContext
{
    public APIContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<PizzaSpecial> Specials { get; set; }
    
    public DbSet<LookupApprovalType> ApprovalTypes { get; set; }
    public DbSet<LookupJustification> Justifications { get; set; }
    public DbSet<LookupPickupLocation> PickupLocations { get; set; }
    public DbSet<LookupRequestType> RequestTypes { get; set; }
    public DbSet<LookupSpecialApprover> SpecialApprovers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuring a many-to-many special -> topping relationship that is friendly for serialization
        modelBuilder.Entity<PizzaTopping>().HasKey(pst => new { pst.PizzaId, pst.ToppingId });
        modelBuilder.Entity<PizzaTopping>().HasOne<Pizza>().WithMany(ps => ps.Toppings);
        modelBuilder.Entity<PizzaTopping>().HasOne(pst => pst.Topping).WithMany();
    }
}