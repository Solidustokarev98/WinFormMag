using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class CameraContext : DbContext
{
    public DbSet<Camera> Cameras { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\kiril\\OneDrive\\Рабочий стол\\Курсовой проект по .NET\\WinFormMag\\WinFormMag\\WFDB.db");
    }
}