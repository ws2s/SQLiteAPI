using Microsoft.EntityFrameworkCore;
using SQLiteAPI.Models;

namespace SQLiteAPI.Data;

public class APIContext : DbContext
{
    public APIContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}