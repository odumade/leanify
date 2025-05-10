//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text.Json;
//using Microsoft.EntityFrameworkCore;
//using Entity;

//namespace Infrastructure.Data
//{
//    public static class DbInitializer
//    {
//        public static void Seed(StoreContext context)
//        {
//            if (context.Courses.Any() && context.Categories.Any() && context.Requirements.Any() && context.Learnings.Any())
//                return; // Avoid re-seeding if data already exists

//            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "SeedData");

//            // Ensure the path exists and log for debugging purposes
//            Console.WriteLine($"SeedData path: {basePath}");

//            // Seed Categories first
//            SeedCategories(context, basePath);

//            // Seed Courses
//            SeedCourses(context, basePath);

//            // Seed Requirements
//            SeedRequirements(context, basePath);

//            // Seed Learnings
//            SeedLearnings(context, basePath);

//            context.SaveChanges();
//            Console.WriteLine("Database seeded successfully!");
//        }

//        private static void SeedCategories(StoreContext context, string basePath)
//        {
//            Console.WriteLine("Seeding categories...");

//            var categoryData = File.ReadAllText(Path.Combine(basePath, "categories.json"));
//            var categories = JsonSerializer.Deserialize<List<Category>>(categoryData);

//            if (categories != null && categories.Any())
//            {
//                context.Categories.AddRange(categories);
//                context.SaveChanges();
//                Console.WriteLine("Categories seeded.");
//            }
//            else
//            {
//                Console.WriteLine("No categories data found.");
//            }
//        }

//        private static void SeedCourses(StoreContext context, string basePath)
//        {
//            Console.WriteLine("Seeding courses...");

//            var courseData = File.ReadAllText(Path.Combine(basePath, "courses.json"));
//            var courses = JsonSerializer.Deserialize<List<Course>>(courseData);

//            if (courses != null && courses.Any())
//            {
//                // Ensure categories are set before adding courses
//                foreach (var course in courses)
//                {
//                    var category = context.Categories.FirstOrDefault(c => c.Id == course.CategoryId);
//                    if (category != null)
//                    {
//                        course.Category = category;
//                    }
//                }

//                context.Courses.AddRange(courses);
//                context.SaveChanges();
//                Console.WriteLine("Courses seeded.");
//            }
//            else
//            {
//                Console.WriteLine("No courses data found.");
//            }
//        }

//        private static void SeedRequirements(StoreContext context, string basePath)
//        {
//            Console.WriteLine("Seeding requirements...");

//            var requirementData = File.ReadAllText(Path.Combine(basePath, "requirements.json"));
//            var requirements = JsonSerializer.Deserialize<List<Requirement>>(requirementData);

//            if (requirements != null && requirements.Any())
//            {
//                foreach (var requirement in requirements)
//                {
//                    var course = context.Courses.FirstOrDefault(c => c.Id == requirement.CourseId);
//                    if (course != null)
//                    {
//                        requirement.Course = course;
//                    }
//                }

//                context.Requirements.AddRange(requirements);
//                context.SaveChanges();
//                Console.WriteLine("Requirements seeded.");
//            }
//            else
//            {
//                Console.WriteLine("No requirements data found.");
//            }
//        }

//        private static void SeedLearnings(StoreContext context, string basePath)
//        {
//            Console.WriteLine("Seeding learnings...");

//            var learningData = File.ReadAllText(Path.Combine(basePath, "learnings.json"));
//            var learnings = JsonSerializer.Deserialize<List<Learning>>(learningData);

//            if (learnings != null && learnings.Any())
//            {
//                foreach (var learning in learnings)
//                {
//                    var course = context.Courses.FirstOrDefault(c => c.Id == learning.CourseId);
//                    if (course != null)
//                    {
//                        learning.Course = course;
//                    }
//                }

//                context.Learnings.AddRange(learnings);
//                context.SaveChanges();
//                Console.WriteLine("Learnings seeded.");
//            }
//            else
//            {
//                Console.WriteLine("No learnings data found.");
//            }
//        }
//    }
//}
