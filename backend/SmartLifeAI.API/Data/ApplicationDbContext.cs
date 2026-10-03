using Microsoft.EntityFrameworkCore;
using SmartLifeAI.API.Models;

namespace SmartLifeAI.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<TimeSlot> TimeSlots { get; set; }
    public DbSet<Timetable> Timetable { get; set; }
    public DbSet<Disruption> Disruptions { get; set; }
}