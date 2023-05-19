using ELearn.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearn.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<MileStone> MileStones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Course>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<CourseImage>().HasQueryFilter(m => !m.SoftDelete);

            modelBuilder.Entity<Author>().HasData(

                new Author
                {
                    Id = 1,
                    FullName = "James S. Morrison"
                },
                new Author
                {
                    Id = 2,
                    FullName = "Mark Smith"
                },
                new Author
                {
                    Id = 3,
                    FullName = "Julia Williams"
                }
            );

            modelBuilder.Entity<Course>().HasData(

                new Course
                {
                    Id = 1,
                    Name = "Online Literature Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 1
                },
                new Course
                {
                    Id = 2,
                    Name = "Social Media Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 2
                },
                new Course
                {
                    Id = 3,
                    Name = "Online Marketing Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 3
                },
                new Course
                {
                    Id = 4,
                    Name = "Online Literature Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 1
                },
                new Course
                {
                    Id = 5,
                    Name = "Social Media Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 2
                },
                new Course
                {
                    Id = 6,
                    Name = "Online Marketing Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 3
                },
                new Course
                {
                    Id = 7,
                    Name = "Online Literature Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 1
                },
                new Course
                {
                    Id = 8,
                    Name = "Social Media Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 2
                },
                new Course
                {
                    Id = 9,
                    Name = "Online Marketing Course",
                    Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                    AuthorId = 3
                }
            );

            modelBuilder.Entity<CourseImage>().HasData(

                new CourseImage
                {
                    Id = 1,
                    Image = "course_1.jpg",
                    IsMain = true,
                    CourseId = 1
                },
                new CourseImage
                {
                    Id = 2,
                    Image = "course_2.jpg",
                    IsMain = true,
                    CourseId = 2
                },
                new CourseImage
                {
                    Id = 3,
                    Image = "course_3.jpg",
                    IsMain = true,
                    CourseId = 3
                },
                new CourseImage
                {
                    Id = 4,
                    Image = "course_4.jpg",
                    IsMain = true,
                    CourseId = 4
                },
                new CourseImage
                {
                    Id = 5,
                    Image = "course_5.jpg",
                    IsMain = true,
                    CourseId = 5
                },
                new CourseImage
                {
                    Id = 6,
                    Image = "course_6.jpg",
                    IsMain = true,
                    CourseId = 6
                },
                new CourseImage
                {
                    Id = 7,
                    Image = "course_7.jpg",
                    IsMain = true,
                    CourseId = 7
                },
                new CourseImage
                {
                    Id = 8,
                    Image = "course_8.jpg",
                    IsMain = true,
                    CourseId = 8
                },
                new CourseImage
                {
                    Id = 9,
                    Image = "course_9.jpg",
                    IsMain = true,
                    CourseId = 9
                }
            );

            
        }


    }
}
