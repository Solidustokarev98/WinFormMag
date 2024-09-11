using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class CameraContext : DbContext
{
    public DbSet<Camera> Cameras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=WFDB.db");
    }
}