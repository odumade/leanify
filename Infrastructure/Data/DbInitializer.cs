using Entity;
using System;

namespace Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Seed(StoreContext context)
        {
            if (!context.Courses.Any())
            {
                var courses = new List<Course>
                {
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "ASP.NET Core Web API",
                        Price = 49.99f,
                        Instructor = "John Doe",
                        Rating = 4.8m,
                        Image = "aspnet.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "React for Beginners",
                        Price = 39.99f,
                        Instructor = "Jane Smith",
                        Rating = 4.6m,
                        Image = "react.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "C# Fundamentals",
                        Price = 29.99f,
                        Instructor = "Michael Johnson",
                        Rating = 4.7m,
                        Image = "csharp.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "Entity Framework Core In Depth",
                        Price = 34.99f,
                        Instructor = "Emily Davis",
                        Rating = 4.9m,
                        Image = "efcore.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "Clean Architecture in .NET",
                        Price = 44.99f,
                        Instructor = "Robert Martin",
                        Rating = 4.8m,
                        Image = "cleanarch.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "Blazor WebAssembly Guide",
                        Price = 39.99f,
                        Instructor = "Sara Thompson",
                        Rating = 4.5m,
                        Image = "blazor.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "Next.js Crash Course",
                        Price = 29.99f,
                        Instructor = "David Lee",
                        Rating = 4.4m,
                        Image = "nextjs.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "Docker for .NET Developers",
                        Price = 34.99f,
                        Instructor = "Anna White",
                        Rating = 4.7m,
                        Image = "docker.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "SQL for Beginners",
                        Price = 24.99f,
                        Instructor = "Chris Green",
                        Rating = 4.3m,
                        Image = "sql.jpg"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Title = "Azure Fundamentals",
                        Price = 39.99f,
                        Instructor = "Linda Brown",
                        Rating = 4.6m,
                        Image = "azure.jpg"
                    }
                };

                context.Courses.AddRange(courses);
                context.SaveChanges();
            }
        }
    }
}
