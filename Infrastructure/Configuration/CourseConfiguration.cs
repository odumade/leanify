using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.Instructor)
                   .HasMaxLength(100);

            builder.Property(c => c.Rating)
                   .HasColumnType("decimal(18,1)");

            builder.Property(c => c.Image)
                   .HasMaxLength(255);

            builder.Property(c => c.Subtitle)
                   .HasMaxLength(200);

            builder.Property(c => c.Description)
                   .HasColumnType("TEXT");

            builder.Property(c => c.Language)
                   .HasMaxLength(50);

            builder.Property(c => c.Level)
                   .HasMaxLength(50);

            builder.Property(c => c.LastUpdated)
                   .HasDefaultValueSql("CURRENT_TIMESTAMP");

            //builder.HasMany(c => c.Requirements)
            //       .WithOne()
            //       .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(c => c.Category)
            //       .WithMany()
            //       .HasForeignKey(c => c.CategoryId)
            //       .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
