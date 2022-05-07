using System;
using Microsoft.EntityFrameworkCore;
namespace DataBase
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=dbirabv012;User Id=bv012irauser;Password=Wds543ieiidijYYdjsi**jdjkUDJEKIDdhYiiskdUUdskkYJDJDNNnndmd73d@sdf88U^ew!;");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}
