﻿// <auto-generated />
using ELearn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ELearn.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230519181548_CreateMileStones")]
    partial class CreateMileStones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ELearn.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "James S. Morrison",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Mark Smith",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Julia Williams",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("ELearn.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Online Literature Course",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Social Media Course",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Online Marketing Course",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Online Literature Course",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 2,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Social Media Course",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 3,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Online Marketing Course",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 1,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Online Literature Course",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 2,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Social Media Course",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 3,
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Name = "Online Marketing Course",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("ELearn.Models.CourseImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Image = "course_1.jpg",
                            IsMain = true,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            Image = "course_2.jpg",
                            IsMain = true,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            Image = "course_3.jpg",
                            IsMain = true,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 4,
                            Image = "course_4.jpg",
                            IsMain = true,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 5,
                            Image = "course_5.jpg",
                            IsMain = true,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 6,
                            Image = "course_6.jpg",
                            IsMain = true,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 7,
                            Image = "course_7.jpg",
                            IsMain = true,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 8,
                            Image = "course_8.jpg",
                            IsMain = true,
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 9,
                            Image = "course_9.jpg",
                            IsMain = true,
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("ELearn.Models.MileStone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MileStones");
                });

            modelBuilder.Entity("ELearn.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("ELearn.Models.Course", b =>
                {
                    b.HasOne("ELearn.Models.Author", "Author")
                        .WithMany("Courses")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ELearn.Models.CourseImage", b =>
                {
                    b.HasOne("ELearn.Models.Course", "Course")
                        .WithMany("CourseImages")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ELearn.Models.Author", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ELearn.Models.Course", b =>
                {
                    b.Navigation("CourseImages");
                });
#pragma warning restore 612, 618
        }
    }
}
