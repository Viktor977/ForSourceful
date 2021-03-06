// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models.Entities;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DbWorkDays))]
    [Migration("20211206110547_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateRegistration = new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "cobolev@prim.com",
                            FirstName = "Dmitry",
                            LastName = "Cobolev",
                            Password = "qwerty",
                            Role = 1
                        },
                        new
                        {
                            Id = 2,
                            DateRegistration = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "gogolev@prim.com",
                            FirstName = "Semen",
                            LastName = "Gogolev",
                            Password = "asdfgh",
                            Role = 1
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("ManagerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataEnd = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataStart = new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 5,
                            ManagerName = "Cobolev",
                            Name = "Workdays for the sprin"
                        },
                        new
                        {
                            Id = 2,
                            DataEnd = new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataStart = new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 20,
                            ManagerName = "Gogolev",
                            Name = "Workdays for the autumn"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("in months");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateRegistration = new DateTime(2021, 12, 6, 13, 5, 46, 728, DateTimeKind.Local).AddTicks(98),
                            Email = "step@gmail.com",
                            Experience = "36 month",
                            FirstName = "Viktor",
                            LastName = "Stepanov",
                            Password = "1111",
                            Role = 0
                        },
                        new
                        {
                            Id = 2,
                            DateRegistration = new DateTime(2021, 12, 6, 13, 5, 46, 730, DateTimeKind.Local).AddTicks(5906),
                            Email = "monov@gmail.com",
                            Experience = "46 month",
                            FirstName = "Igor",
                            LastName = "Pokimonov",
                            Password = "2222",
                            Role = 0
                        },
                        new
                        {
                            Id = 3,
                            DateRegistration = new DateTime(2021, 12, 6, 13, 5, 46, 730, DateTimeKind.Local).AddTicks(5942),
                            Email = "ivan@gmail.com",
                            Experience = "12 month",
                            FirstName = "Ivan",
                            LastName = "Pervij",
                            Password = "3333",
                            Role = 0
                        },
                        new
                        {
                            Id = 4,
                            DateRegistration = new DateTime(2021, 12, 6, 13, 5, 46, 730, DateTimeKind.Local).AddTicks(5947),
                            Email = "cruz@gmail.com",
                            Experience = "28 month",
                            FirstName = "Tom",
                            LastName = "Cruz",
                            Password = "4444",
                            Role = 0
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.Schedule", b =>
                {
                    b.HasOne("WebApplication1.Models.Entities.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.User", b =>
                {
                    b.HasOne("WebApplication1.Models.Entities.Manager", null)
                        .WithMany("Workers")
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("WebApplication1.Models.Entities.Manager", b =>
                {
                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
