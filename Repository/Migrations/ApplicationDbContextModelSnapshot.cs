﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Data;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repository.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaseCount")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("DeliveryTime")
                        .HasColumnType("time");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.HasKey("DeliveryId");

                    b.ToTable("Deliveries");

                    b.HasData(
                        new
                        {
                            DeliveryId = 1,
                            CaseCount = 100,
                            DeliveryTime = new TimeSpan(0, 8, 15, 0, 0),
                            DriverId = 3
                        },
                        new
                        {
                            DeliveryId = 2,
                            CaseCount = 65,
                            DeliveryTime = new TimeSpan(0, 9, 30, 0, 0),
                            DriverId = 3
                        },
                        new
                        {
                            DeliveryId = 3,
                            CaseCount = 98,
                            DeliveryTime = new TimeSpan(0, 10, 11, 0, 0),
                            DriverId = 3
                        },
                        new
                        {
                            DeliveryId = 4,
                            CaseCount = 72,
                            DeliveryTime = new TimeSpan(0, 6, 0, 0, 0),
                            DriverId = 3
                        },
                        new
                        {
                            DeliveryId = 5,
                            CaseCount = 89,
                            DeliveryTime = new TimeSpan(0, 12, 30, 0, 0),
                            DriverId = 3
                        });
                });

            modelBuilder.Entity("Repository.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("RouteId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Name = "Aaron Madison",
                            PhoneNumber = "123-456-7891",
                            Position = "Sales Representative",
                            RouteId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            Name = "Amanda Miller",
                            PhoneNumber = "123-456-7891",
                            Position = "Merchandier",
                            RouteId = 2
                        },
                        new
                        {
                            EmployeeId = 3,
                            Name = "David Wroblewski",
                            PhoneNumber = "123-456-7891",
                            Position = "Driver",
                            RouteId = 3
                        });
                });

            modelBuilder.Entity("Repository.Models.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RouteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("RouteId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Routes");

                    b.HasData(
                        new
                        {
                            RouteId = 1,
                            RouteName = "CWMLAA",
                            ScheduleId = 11
                        },
                        new
                        {
                            RouteId = 2,
                            RouteName = "CWMLAB",
                            ScheduleId = 12
                        },
                        new
                        {
                            RouteId = 3,
                            RouteName = "CWMLAC",
                            ScheduleId = 13
                        });
                });

            modelBuilder.Entity("Repository.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            ScheduleId = 1,
                            StoreId = 1
                        },
                        new
                        {
                            ScheduleId = 2,
                            StoreId = 2
                        },
                        new
                        {
                            ScheduleId = 3,
                            StoreId = 3
                        },
                        new
                        {
                            ScheduleId = 4,
                            StoreId = 4
                        },
                        new
                        {
                            ScheduleId = 5,
                            StoreId = 5
                        },
                        new
                        {
                            ScheduleId = 6,
                            StoreId = 6
                        },
                        new
                        {
                            ScheduleId = 7,
                            StoreId = 7
                        },
                        new
                        {
                            ScheduleId = 8,
                            StoreId = 8
                        },
                        new
                        {
                            ScheduleId = 9,
                            StoreId = 9
                        },
                        new
                        {
                            ScheduleId = 10,
                            StoreId = 10
                        },
                        new
                        {
                            ScheduleId = 11,
                            EmployeeId = 1
                        },
                        new
                        {
                            ScheduleId = 12,
                            EmployeeId = 2
                        },
                        new
                        {
                            ScheduleId = 13,
                            EmployeeId = 3
                        });
                });

            modelBuilder.Entity("Repository.Models.Stop", b =>
                {
                    b.Property<int>("StopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StopId");

                    b.HasIndex("DeliveryId");

                    b.ToTable("Stops");

                    b.HasData(
                        new
                        {
                            StopId = 1,
                            DayOfWeek = 1,
                            DeliveryId = 1,
                            EmployeeId = 1,
                            StoreId = 1,
                            Type = "Delivery"
                        },
                        new
                        {
                            StopId = 2,
                            DayOfWeek = 1,
                            DeliveryId = 2,
                            EmployeeId = 1,
                            StoreId = 2,
                            Type = "Delivery"
                        },
                        new
                        {
                            StopId = 3,
                            DayOfWeek = 1,
                            DeliveryId = 3,
                            EmployeeId = 1,
                            StoreId = 3,
                            Type = "Delivery"
                        },
                        new
                        {
                            StopId = 4,
                            DayOfWeek = 1,
                            EmployeeId = 1,
                            StoreId = 4,
                            Type = "Write Order"
                        },
                        new
                        {
                            StopId = 5,
                            DayOfWeek = 1,
                            EmployeeId = 1,
                            StoreId = 5,
                            Type = "Write Order"
                        },
                        new
                        {
                            StopId = 6,
                            DayOfWeek = 1,
                            DeliveryId = 4,
                            EmployeeId = 2,
                            StoreId = 6,
                            Type = "Delivery"
                        },
                        new
                        {
                            StopId = 7,
                            DayOfWeek = 1,
                            DeliveryId = 5,
                            EmployeeId = 2,
                            StoreId = 7,
                            Type = "Delivery"
                        },
                        new
                        {
                            StopId = 8,
                            DayOfWeek = 1,
                            EmployeeId = 2,
                            StoreId = 8,
                            Type = "Merchandise"
                        },
                        new
                        {
                            StopId = 9,
                            DayOfWeek = 1,
                            EmployeeId = 2,
                            StoreId = 9,
                            Type = "Merchandise"
                        },
                        new
                        {
                            StopId = 10,
                            DayOfWeek = 1,
                            EmployeeId = 2,
                            StoreId = 10,
                            Type = "Merchandise"
                        },
                        new
                        {
                            StopId = 11,
                            DayOfWeek = 1,
                            DeliveryId = 1,
                            EmployeeId = 3,
                            StoreId = 1,
                            Type = "Drop Off"
                        },
                        new
                        {
                            StopId = 12,
                            DayOfWeek = 1,
                            DeliveryId = 2,
                            EmployeeId = 3,
                            StoreId = 2,
                            Type = "Drop Off"
                        },
                        new
                        {
                            StopId = 13,
                            DayOfWeek = 1,
                            DeliveryId = 3,
                            EmployeeId = 3,
                            StoreId = 3,
                            Type = "Drop Off"
                        },
                        new
                        {
                            StopId = 14,
                            DayOfWeek = 1,
                            DeliveryId = 4,
                            EmployeeId = 3,
                            StoreId = 6,
                            Type = "Drop Off"
                        },
                        new
                        {
                            StopId = 15,
                            DayOfWeek = 1,
                            DeliveryId = 5,
                            EmployeeId = 3,
                            StoreId = 7,
                            Type = "Drop Off"
                        });
                });

            modelBuilder.Entity("Repository.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Long")
                        .HasColumnType("float");

                    b.Property<string>("PlaceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            StoreId = 1,
                            Lat = 42.984206999999998,
                            Long = -87.912901000000005,
                            PlaceId = "ChIJfZyRV2oXBYgR_hLJNn-fnEg",
                            ScheduleId = 1,
                            StoreName = "Pick n Save Holt",
                            StreetAddress = "250 W Holt Ave, Milwaukee, WI, 53207"
                        },
                        new
                        {
                            StoreId = 2,
                            Lat = 42.968153999999998,
                            Long = -88.009032000000005,
                            PlaceId = "ChIJpUBh1isQBYgR1nJjjs36yVE",
                            ScheduleId = 2,
                            StoreName = "Pick n Save Coldspring",
                            StreetAddress = "4279 S 76th St, Greenfield, WI 53220"
                        },
                        new
                        {
                            StoreId = 3,
                            Lat = 42.997154000000002,
                            Long = -88.049858,
                            PlaceId = "ChIJ-wwouYMPBYgRugMGerzM4Ec",
                            ScheduleId = 3,
                            StoreName = "Pick n Save Cleveland",
                            StreetAddress = "2625 S 108th St, West Allis, WI 53227"
                        },
                        new
                        {
                            StoreId = 4,
                            Lat = 42.997076,
                            Long = -88.045524,
                            PlaceId = "ChIJuXhmDoQPBYgRK8eTQCbhzRw",
                            ScheduleId = 4,
                            StoreName = "Target West Allis",
                            StreetAddress = "2600 S 108th St, West Allis, WI 53227"
                        },
                        new
                        {
                            StoreId = 5,
                            Lat = 42.939061000000002,
                            Long = -88.045790999999994,
                            PlaceId = "ChIJ8fooCWQOBYgRXnOW9RqNh68",
                            ScheduleId = 5,
                            StoreName = "Pick n Save Hales Corners",
                            StreetAddress = "5800 S 108th St, Hales Corners, WI 53130"
                        },
                        new
                        {
                            StoreId = 6,
                            Lat = 42.939061000000002,
                            Long = -88.045790999999994,
                            PlaceId = "ChIJn_sIpcMIBYgRoDPHQpNiEh4",
                            ScheduleId = 6,
                            StoreName = "Pick n Save New Berlin",
                            StreetAddress = "15445 W National Ave, New Berlin, WI 53151"
                        },
                        new
                        {
                            StoreId = 7,
                            Lat = 42.908267000000002,
                            Long = -88.125995000000003,
                            PlaceId = "ChIJFV_PrMsLBYgRFkmNWGjYHu0",
                            ScheduleId = 7,
                            StoreName = "Pick n Save Muskego",
                            StreetAddress = "Janesville Rd S74 W17005, Muskego, WI 53150"
                        },
                        new
                        {
                            StoreId = 8,
                            Lat = 42.896918999999997,
                            Long = -87.915362999999999,
                            PlaceId = "ChIJST_O6UIUBYgRJctdFiQ0ofw",
                            ScheduleId = 8,
                            StoreName = "Woodmans Oak Creek",
                            StreetAddress = "8131 S Howell Ave, Oak Creek, WI 53154"
                        },
                        new
                        {
                            StoreId = 9,
                            Lat = 42.960138999999998,
                            Long = -88.044126000000006,
                            PlaceId = "ChIJk_y7zFQOBYgRew-_R_fb4nc",
                            ScheduleId = 9,
                            StoreName = "Walmart Layton Ave",
                            StreetAddress = "10600 W Layton Ave, Greenfield, WI 53228"
                        },
                        new
                        {
                            StoreId = 10,
                            Lat = 42.926501000000002,
                            Long = -88.110527000000005,
                            PlaceId = "ChIJi5-Z_t0LBYgR_IeEp3884As",
                            ScheduleId = 10,
                            StoreName = "Walmart Muskego",
                            StreetAddress = "W159s6530 Moorland Rd, Muskego, WI 53150"
                        });
                });

            modelBuilder.Entity("Repository.Models.Employee", b =>
                {
                    b.HasOne("Repository.Models.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Models.Route", b =>
                {
                    b.HasOne("Repository.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Models.Stop", b =>
                {
                    b.HasOne("Repository.Models.Delivery", "Delivery")
                        .WithMany()
                        .HasForeignKey("DeliveryId");
                });

            modelBuilder.Entity("Repository.Models.Store", b =>
                {
                    b.HasOne("Repository.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
