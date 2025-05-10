using Entity;
using Microsoft.EntityFrameworkCore;

public static class DataSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        // Seed Categories
        var categories = new List<Category>
    {
        new() { Id = 1, Name = "Programming" },
        new() { Id = 2, Name = "Design" },
        new() { Id = 3, Name = "Business" }
    };
        modelBuilder.Entity<Category>().HasData(categories);

        // Seed Courses
        var courseId1 = Guid.Parse("11111111-1111-1111-1111-111111111111"); // Fixed GUIDs
        var courseId2 = Guid.Parse("22222222-2222-2222-2222-222222222222");

        var courses = new List<Course>
    {
        new()
        {
            Id = courseId1,
            Title = "C# Masterclass",
            // ... other properties
            CategoryId = 1
        },
        new()
        {
            Id = courseId2,
            Title = "Web Design",
            // ... other properties
            CategoryId = 2
        }
    };
        modelBuilder.Entity<Course>().HasData(courses);

        // Seed Requirements - EXPLICIT configuration
        modelBuilder.Entity<Requirement>().HasData(
            new Requirement { Id = 1, Name = "Basic programming", CourseId = courseId1 },
            new Requirement { Id = 2, Name = "Visual Studio", CourseId = courseId1 },
            new Requirement { Id = 3, Name = "Creative mindset", CourseId = courseId2 }
        );

        // Seed Learnings - EXPLICIT configuration
        modelBuilder.Entity<Learning>().HasData(
            new Learning { Id = 1, Name = "OOP Principles", CourseId = courseId1 },
            new Learning { Id = 2, Name = "ASP.NET Core", CourseId = courseId1 },
            new Learning { Id = 3, Name = "Responsive Design", CourseId = courseId2 }
        );
    }
}