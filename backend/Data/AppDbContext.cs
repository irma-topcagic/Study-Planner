using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data;

public class AppDbContext: DbContext{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}

    public DbSet<User> Users{get; set;}
    public DbSet<Subject>Subjects{get; set;}
    public DbSet<StudyTask> StudyTasks{get; set;}
    public DbSet<StudySession> StudySessions{get; set;}
}