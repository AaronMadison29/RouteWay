using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RouteStore>()
                .HasKey(c => new { c.RouteId, c.StoreId });
            builder.Entity<ScheduleStop>()
                .HasKey(c => new { c.ScheduleId, c.StopId });

            //Employees
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Aaron Madison",
                    Position = "Sales Representative",
                    PhoneNumber = "123-456-7891",
                    RouteId = 1
                }
                );
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Amanda Miller",
                    Position = "Merchandiser",
                    PhoneNumber = "123-456-7891",
                    RouteId = 2
                }
                );
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 3,
                    Name = "David Wroblewski",
                    Position = "Driver",
                    PhoneNumber = "123-456-7891",
                    RouteId = 3
                }
                );

            //Schedule
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 1,
                    StoreId = 1,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 2,
                    StoreId = 2,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 3,
                    StoreId = 3,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 4,
                    StoreId = 4,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 5,
                    StoreId = 5,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 6,
                    StoreId = 6,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 7,
                    StoreId = 7,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 8,
                    StoreId = 8,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 9,
                    StoreId = 9,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 10,
                    StoreId = 10,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 11,
                    EmployeeId = 1,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 12,
                    EmployeeId = 2,
                }
                );
            builder.Entity<Schedule>().HasData(
                new Schedule
                {
                    ScheduleId = 13,
                    EmployeeId = 3,
                }
                );

            //Routes
            builder.Entity<Route>().HasData(
                new Route
                {
                    RouteId = 1,
                    RouteName = "CWMLAA",
                    ScheduleId = 11,
                }
                );
            builder.Entity<Route>().HasData(
                new Route
                {
                    RouteId = 2,
                    RouteName = "CWMLAB",
                    ScheduleId = 12,
                }
                );
            builder.Entity<Route>().HasData(
                new Route
                {
                    RouteId = 3,
                    RouteName = "CWMLAC",
                    ScheduleId = 13,
                }
                );

            //Stores
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 1,
                    StoreName = "Pick n Save Holt",
                    PlaceId = "ChIJfZyRV2oXBYgR_hLJNn-fnEg",
                    StreetAddress = "250 W Holt Ave, Milwaukee, WI, 53207",
                    Lat = 42.984207,
                    Long = -87.912901,
                    ScheduleId = 1
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 2,
                    StoreName = "Pick n Save Coldspring",
                    PlaceId = "ChIJpUBh1isQBYgR1nJjjs36yVE",
                    StreetAddress = "4279 S 76th St, Greenfield, WI 53220",
                    Lat = 42.968154,
                    Long = -88.009032,
                    ScheduleId = 2
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 3,
                    StoreName = "Pick n Save Cleveland",
                    PlaceId = "ChIJ-wwouYMPBYgRugMGerzM4Ec",
                    StreetAddress = "2625 S 108th St, West Allis, WI 53227",
                    Lat = 42.997154,
                    Long = -88.049858,
                    ScheduleId = 3
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 4,
                    StoreName = "Target West Allis",
                    PlaceId = "ChIJuXhmDoQPBYgRK8eTQCbhzRw",
                    StreetAddress = "2600 S 108th St, West Allis, WI 53227",
                    Lat = 42.997076,
                    Long = -88.045524,
                    ScheduleId = 4
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 5,
                    StoreName = "Pick n Save Hales Corners",
                    PlaceId = "ChIJ8fooCWQOBYgRXnOW9RqNh68",
                    StreetAddress = "5800 S 108th St, Hales Corners, WI 53130",
                    Lat = 42.939061,
                    Long = -88.045791,
                    ScheduleId = 5
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 6,
                    StoreName = "Pick n Save New Berlin",
                    PlaceId = "ChIJn_sIpcMIBYgRoDPHQpNiEh4",
                    StreetAddress = "15445 W National Ave, New Berlin, WI 53151",
                    Lat = 42.939061,
                    Long = -88.045791,
                    ScheduleId = 6
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 7,
                    StoreName = "Pick n Save Muskego",
                    PlaceId = "ChIJFV_PrMsLBYgRFkmNWGjYHu0",
                    StreetAddress = "Janesville Rd S74 W17005, Muskego, WI 53150",
                    Lat = 42.908267,
                    Long = -88.125995,
                    ScheduleId = 7
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 8,
                    StoreName = "Woodmans Oak Creek",
                    PlaceId = "ChIJST_O6UIUBYgRJctdFiQ0ofw",
                    StreetAddress = "8131 S Howell Ave, Oak Creek, WI 53154",
                    Lat = 42.896919,
                    Long = -87.915363,
                    ScheduleId = 8
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 9,
                    StoreName = "Walmart Layton Ave",
                    PlaceId = "ChIJk_y7zFQOBYgRew-_R_fb4nc",
                    StreetAddress = "10600 W Layton Ave, Greenfield, WI 53228",
                    Lat = 42.960139,
                    Long = -88.044126,
                    ScheduleId = 9
                }
                );
            builder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 10,
                    StoreName = "Walmart Muskego",
                    PlaceId = "ChIJi5-Z_t0LBYgR_IeEp3884As",
                    StreetAddress = "W159s6530 Moorland Rd, Muskego, WI 53150",
                    Lat = 42.926501,
                    Long = -88.110527,
                    ScheduleId = 10
                }
                );

            //Deliveries
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 1,
                    DriverId = 3,
                    CaseCount = 100,
                    DeliveryTime = new TimeSpan(8, 15, 00),
                }
                );
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 2,
                    DriverId = 3,
                    CaseCount = 65,
                    DeliveryTime = new TimeSpan(9, 30, 00),
                }
                );
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 3,
                    DriverId = 3,
                    CaseCount = 98,
                    DeliveryTime = new TimeSpan(10, 11, 00),
                }
                );
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 4,
                    DriverId = 3,
                    CaseCount = 72,
                    DeliveryTime = new TimeSpan(6, 00, 00),
                }
                );
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 5,
                    DriverId = 3,
                    CaseCount = 89,
                    DeliveryTime = new TimeSpan(12, 30, 00),
                }
                );

            //Stops
            //Employee 1 Monday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 1,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 1,
                    EmployeeId = 1,
                    DeliveryId = 1
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 2,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 2,
                    EmployeeId = 1,
                    DeliveryId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 3,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 3,
                    EmployeeId = 1,
                    DeliveryId = 3
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 4,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 4,
                    EmployeeId = 1
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 5,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 5,
                    EmployeeId = 1
                }
                );
            //Employee 2 Monday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 6,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 6,
                    EmployeeId = 2,
                    DeliveryId = 4
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 7,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 7,
                    EmployeeId = 2,
                    DeliveryId = 5
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 8,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 8,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 9,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 9,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 10,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 10,
                    EmployeeId = 2
                }
                );
            //Employee 3 Monday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 11,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 1,
                    EmployeeId = 3,
                    DeliveryId = 1
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 12,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 2,
                    EmployeeId = 3,
                    DeliveryId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 13,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 3,
                    EmployeeId = 3,
                    DeliveryId = 3
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 14,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 6,
                    EmployeeId = 3,
                    DeliveryId = 4
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 15,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Monday,
                    StoreId = 7,
                    EmployeeId = 3,
                    DeliveryId = 5
                }
                );

            //RouteStores
            int count = 1;
            for (int y = 1; y <= 3; y++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    builder.Entity<RouteStore>().HasData(
                        new RouteStore
                        {
                            RouteStoreId = count,
                            RouteId = y,
                            StoreId = i
                        }
                        );
                    count++;
                }
            }

            //ScheduleStops
            //Employee One's Schedule
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 1,
                    ScheduleId = 11,
                    StopId = 1,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 2,
                    ScheduleId = 11,
                    StopId = 2,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 3,
                    ScheduleId = 11,
                    StopId = 3,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 4,
                    ScheduleId = 11,
                    StopId = 4,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 5,
                    ScheduleId = 11,
                    StopId = 5,
                }
                );
            //Employee Two's Schedule
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 6,
                    ScheduleId = 12,
                    StopId = 6,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 7,
                    ScheduleId = 12,
                    StopId = 7,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 8,
                    ScheduleId = 12,
                    StopId = 8,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 9,
                    ScheduleId = 12,
                    StopId = 9,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 10,
                    ScheduleId = 12,
                    StopId = 10,
                }
                );
            //Employee Three's Schedule
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 11,
                    ScheduleId = 13,
                    StopId = 11,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 12,
                    ScheduleId = 13,
                    StopId = 12,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 13,
                    ScheduleId = 13,
                    StopId = 13,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 14,
                    ScheduleId = 13,
                    StopId = 14,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 15,
                    ScheduleId = 13,
                    StopId = 15,
                }
                );
            //Store 1 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 1,
                    StopId = 1,
                }
                );
            //Store 2 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 2,
                    StopId = 2,
                }
                );
            //Store 3 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 3,
                    StopId = 3,
                }
                );
            //Store 4 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 4,
                    StopId = 4,
                }
                );
            //Store 5 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 5,
                    StopId = 5,
                }
                );
            //Store 6 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 6,
                    StopId = 6,
                }
                );
            //Store 7 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 7,
                    StopId = 7,
                }
                );
            //Store 8 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 8,
                    StopId = 8,
                }
                );
            //Store 9 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 9,
                    StopId = 9,
                }
                );
            //Store 10 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 10,
                    StopId = 10,
                }
                );
        }



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<RouteStore> RouteStores { get; set; }
        public DbSet<ScheduleStop> ScheduleStops { get; set; }
    }
}
