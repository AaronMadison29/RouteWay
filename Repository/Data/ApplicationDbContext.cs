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
                    DeliveryTime = "08:15:00"
                }
                );
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 2,
                    DriverId = 3,
                    CaseCount = 65,
                    DeliveryTime = "09:30:00"
                }
                );
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 3,
                    DriverId = 3,
                    CaseCount = 98,
                    DeliveryTime = "10:11:00"
                }
                );
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 4,
                    DriverId = 3,
                    CaseCount = 72,
                    DeliveryTime = "6:30:00"
                }
                );
            builder.Entity<Delivery>().HasData(
                new Delivery
                {
                    DeliveryId = 5,
                    DriverId = 3,
                    CaseCount = 89,
                    DeliveryTime = "12:15:00"
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
            //Employee 1 Tuesday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 16,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 8,
                    EmployeeId = 1,
                    DeliveryId = 6
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 17,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 9,
                    EmployeeId = 1,
                    DeliveryId = 7
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 18,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 10,
                    EmployeeId = 1,
                    DeliveryId = 8
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 19 ,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 6,
                    EmployeeId = 1
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 20,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 7,
                    EmployeeId = 1
                }
                );
            //Employee 2 Tuesday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 21,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 4,
                    EmployeeId = 2,
                    DeliveryId = 9
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 22,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 5,
                    EmployeeId = 2,
                    DeliveryId = 10
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 23,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 1,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 24,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 2,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 25,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 3,
                    EmployeeId = 2
                }
                );
            //Employee 3 Tuesday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 26,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 8,
                    EmployeeId = 3,
                    DeliveryId = 6
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 27,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 9,
                    EmployeeId = 3,
                    DeliveryId = 7
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 28,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 10,
                    EmployeeId = 3,
                    DeliveryId = 8
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 29,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 4,
                    EmployeeId = 3,
                    DeliveryId = 9
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 30,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StoreId = 5,
                    EmployeeId = 3,
                    DeliveryId = 10
                }
                );
            //Employee 1 Wednesday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 31,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 1,
                    EmployeeId = 1,
                    DeliveryId = 11
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 32,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 2,
                    EmployeeId = 1,
                    DeliveryId = 12
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 33,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 3,
                    EmployeeId = 1,
                    DeliveryId = 13
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 34,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 4,
                    EmployeeId = 1
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 35,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 5,
                    EmployeeId = 1
                }
                );
            //Employee 2 Wednesday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 36,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 6,
                    EmployeeId = 2,
                    DeliveryId = 14
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 37,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 7,
                    EmployeeId = 2,
                    DeliveryId = 15
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 38,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 8,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 39,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 9,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 40,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 10,
                    EmployeeId = 2
                }
                );
            //Employee 3 Wednesday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 41,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 1,
                    EmployeeId = 3,
                    DeliveryId = 11
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 42,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 2,
                    EmployeeId = 3,
                    DeliveryId = 12
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 43,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 3,
                    EmployeeId = 3,
                    DeliveryId = 13
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 44,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 6,
                    EmployeeId = 3,
                    DeliveryId = 14
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 45,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StoreId = 7,
                    EmployeeId = 3,
                    DeliveryId = 15
                }
                );
            //Employee 1 Thursday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 46,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 8,
                    EmployeeId = 1,
                    DeliveryId = 16
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 47,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 9,
                    EmployeeId = 1,
                    DeliveryId = 17
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 48,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 10,
                    EmployeeId = 1,
                    DeliveryId = 18
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 49,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 6,
                    EmployeeId = 1
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 50,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 7,
                    EmployeeId = 1
                }
                );
            //Employee 2 Thursday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 51,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 4,
                    EmployeeId = 2,
                    DeliveryId = 19
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 52,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 5,
                    EmployeeId = 2,
                    DeliveryId = 20
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 53,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 1,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 54,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 2,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 55,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 3,
                    EmployeeId = 2
                }
                );
            //Employee 3 Thursday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 56,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 8,
                    EmployeeId = 3,
                    DeliveryId = 16
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 57,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 9,
                    EmployeeId = 3,
                    DeliveryId = 17
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 58,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 10,
                    EmployeeId = 3,
                    DeliveryId = 18
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 59,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 4,
                    EmployeeId = 3,
                    DeliveryId = 19
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 60,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Thursday,
                    StoreId = 5,
                    EmployeeId = 3,
                    DeliveryId = 20
                }
                );
            //Employee 1 Friday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 61,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 1,
                    EmployeeId = 1,
                    DeliveryId = 21
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 62,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 2,
                    EmployeeId = 1,
                    DeliveryId = 22
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 63,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 3,
                    EmployeeId = 1,
                    DeliveryId = 23
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 64,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 4,
                    EmployeeId = 1
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 65,
                    Type = "Write Order",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 5,
                    EmployeeId = 1
                }
                );
            //Employee 2 Friday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 66,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 6,
                    EmployeeId = 2,
                    DeliveryId = 24
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 67,
                    Type = "Delivery",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 7,
                    EmployeeId = 2,
                    DeliveryId = 25
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 68,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 8,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 69,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 9,
                    EmployeeId = 2
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 70,
                    Type = "Merchandise",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 10,
                    EmployeeId = 2
                }
                );
            //Employee 3 Friday
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 71,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 1,
                    EmployeeId = 3,
                    DeliveryId = 21
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 72,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 2,
                    EmployeeId = 3,
                    DeliveryId = 22
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 73,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 3,
                    EmployeeId = 3,
                    DeliveryId = 23
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 74,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 6,
                    EmployeeId = 3,
                    DeliveryId = 24
                }
                );
            builder.Entity<Stop>().HasData(
                new Stop
                {
                    StopId = 75,
                    Type = "Drop Off",
                    DayOfWeek = DayOfWeek.Friday,
                    StoreId = 7,
                    EmployeeId = 3,
                    DeliveryId = 25
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
            //Monday
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
            //Tuesday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 16,
                    ScheduleId = 11,
                    StopId = 16,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 17,
                    ScheduleId = 11,
                    StopId = 17,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 18,
                    ScheduleId = 11,
                    StopId = 18,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 19,
                    ScheduleId = 11,
                    StopId = 19,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 20,
                    ScheduleId = 11,
                    StopId = 20,
                }
                );
            //Wednesday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 31,
                    ScheduleId = 11,
                    StopId = 31,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 32,
                    ScheduleId = 11,
                    StopId = 32,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 33,
                    ScheduleId = 11,
                    StopId = 33,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 34,
                    ScheduleId = 11,
                    StopId = 34,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 35,
                    ScheduleId = 11,
                    StopId = 35,
                }
                );
            //Thursday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 46,
                    ScheduleId = 11,
                    StopId = 46,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 47,
                    ScheduleId = 11,
                    StopId = 47,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 48,
                    ScheduleId = 11,
                    StopId = 48,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 49,
                    ScheduleId = 11,
                    StopId = 49,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 50,
                    ScheduleId = 11,
                    StopId = 50,
                }
                );
            //Friday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 61,
                    ScheduleId = 11,
                    StopId = 61,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 62,
                    ScheduleId = 11,
                    StopId = 62,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 63,
                    ScheduleId = 11,
                    StopId = 63,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 64,
                    ScheduleId = 11,
                    StopId = 64,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 65,
                    ScheduleId = 11,
                    StopId = 65,
                }
                );
            //Employee Two's Schedule
            //Monday
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
            //Tuesday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 21,
                    ScheduleId = 12,
                    StopId = 21,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 22,
                    ScheduleId = 12,
                    StopId = 22,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 23,
                    ScheduleId = 12,
                    StopId = 23,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 24,
                    ScheduleId = 12,
                    StopId = 24,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 25,
                    ScheduleId = 12,
                    StopId = 25,
                }
                );
            //Wednesday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 36,
                    ScheduleId = 12,
                    StopId = 36,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 37,
                    ScheduleId = 12,
                    StopId = 37,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 38,
                    ScheduleId = 12,
                    StopId = 38,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 39,
                    ScheduleId = 12,
                    StopId = 39,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 40,
                    ScheduleId = 12,
                    StopId = 40,
                }
                );
            //Thursday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 51,
                    ScheduleId = 12,
                    StopId = 51,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 52,
                    ScheduleId = 12,
                    StopId = 52,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 53,
                    ScheduleId = 12,
                    StopId = 53,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 54,
                    ScheduleId = 12,
                    StopId = 54,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 55,
                    ScheduleId = 12,
                    StopId = 55,
                }
                );
            //Friday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 66,
                    ScheduleId = 12,
                    StopId = 66,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 67,
                    ScheduleId = 12,
                    StopId = 67,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 68,
                    ScheduleId = 12,
                    StopId = 68,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 69,
                    ScheduleId = 12,
                    StopId = 69,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 70,
                    ScheduleId = 12,
                    StopId = 70,
                }
                );
            //Employee Three's Schedule
            //Monday
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
            //Tuesday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 26,
                    ScheduleId = 13,
                    StopId = 26,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 27,
                    ScheduleId = 13,
                    StopId = 27,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 28,
                    ScheduleId = 13,
                    StopId = 28,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 29,
                    ScheduleId = 13,
                    StopId = 29,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 30,
                    ScheduleId = 13,
                    StopId = 30,
                }
                );
            //Wednesday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 41,
                    ScheduleId = 13,
                    StopId = 41,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 42,
                    ScheduleId = 13,
                    StopId = 42,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 43,
                    ScheduleId = 13,
                    StopId = 43,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 44,
                    ScheduleId = 13,
                    StopId = 44,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 45,
                    ScheduleId = 13,
                    StopId = 45,
                }
                );
            //Thursday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 56,
                    ScheduleId = 13,
                    StopId = 56,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 57,
                    ScheduleId = 13,
                    StopId = 57,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 58,
                    ScheduleId = 13,
                    StopId = 58,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 59,
                    ScheduleId = 13,
                    StopId = 59,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 60,
                    ScheduleId = 13,
                    StopId = 60,
                }
                );
            //Friday
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 71,
                    ScheduleId = 13,
                    StopId = 71,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 72,
                    ScheduleId = 13,
                    StopId = 72,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 73,
                    ScheduleId = 13,
                    StopId = 73,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 74,
                    ScheduleId = 13,
                    StopId = 74,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 75,
                    ScheduleId = 13,
                    StopId = 75,
                }
                );
            //Store 1 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 76,
                    ScheduleId = 1,
                    StopId = 1,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 77,
                    ScheduleId = 1,
                    StopId = 11,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 78,
                    ScheduleId = 1,
                    StopId = 23,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 78,
                    ScheduleId = 1,
                    StopId = 31,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 79,
                    ScheduleId = 1,
                    StopId = 41,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 80,
                    ScheduleId = 1,
                    StopId = 53,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 81,
                    ScheduleId = 1,
                    StopId = 61,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 82,
                    ScheduleId = 1,
                    StopId = 71,
                }
                );
            //Store 2 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 83,
                    ScheduleId = 2,
                    StopId = 2,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 84,
                    ScheduleId = 2,
                    StopId = 12,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 85,
                    ScheduleId = 2,
                    StopId = 24,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 86,
                    ScheduleId = 2,
                    StopId = 32,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 87,
                    ScheduleId = 2,
                    StopId = 42,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 88,
                    ScheduleId = 2,
                    StopId = 54,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 89,
                    ScheduleId = 2,
                    StopId = 62,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 90,
                    ScheduleId = 2,
                    StopId = 72,
                }
                );
            //Store 3 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 91,
                    ScheduleId = 3,
                    StopId = 3,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 92,
                    ScheduleId = 3,
                    StopId = 13,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 93,
                    ScheduleId = 3,
                    StopId = 25,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 94,
                    ScheduleId = 3,
                    StopId = 33,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 95,
                    ScheduleId = 3,
                    StopId = 43,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 96,
                    ScheduleId = 3,
                    StopId = 55,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 97,
                    ScheduleId = 3,
                    StopId = 63,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 98,
                    ScheduleId = 3,
                    StopId = 73,
                }
                );
            //Store 4 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 99,
                    ScheduleId = 4,
                    StopId = 4,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 100,
                    ScheduleId = 4,
                    StopId = 21,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 101,
                    ScheduleId = 4,
                    StopId = 29,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 102,
                    ScheduleId = 4,
                    StopId = 34,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 103,
                    ScheduleId = 4,
                    StopId = 51,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 104,
                    ScheduleId = 4,
                    StopId = 59,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 105,
                    ScheduleId = 4,
                    StopId = 64,
                }
                );
            //Store 5 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 106,
                    ScheduleId = 5,
                    StopId = 5,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 107,
                    ScheduleId = 5,
                    StopId = 22,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 108,
                    ScheduleId = 5,
                    StopId = 30,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 109,
                    ScheduleId = 5,
                    StopId = 35,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 110,
                    ScheduleId = 5,
                    StopId = 52,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 111,
                    ScheduleId = 5,
                    StopId = 60,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 112,
                    ScheduleId = 5,
                    StopId = 65,
                }
                );
            //Store 6 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 113,
                    ScheduleId = 6,
                    StopId = 6,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 114,
                    ScheduleId = 6,
                    StopId = 14,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 115,
                    ScheduleId = 6,
                    StopId = 26,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 116,
                    ScheduleId = 6,
                    StopId = 34,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 117,
                    ScheduleId = 6,
                    StopId = 44,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 118,
                    ScheduleId = 6,
                    StopId = 56,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 119,
                    ScheduleId = 6,
                    StopId = 64,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 120,
                    ScheduleId = 6,
                    StopId = 74,
                }
                );
            //Store 7 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 121,
                    ScheduleId = 7,
                    StopId = 7,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 122,
                    ScheduleId = 7,
                    StopId = 15,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 123,
                    ScheduleId = 7,
                    StopId = 20,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 124,
                    ScheduleId = 7,
                    StopId = 37,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 125,
                    ScheduleId = 7,
                    StopId = 45,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 126,
                    ScheduleId = 7,
                    StopId = 50,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 127,
                    ScheduleId = 7,
                    StopId = 67,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 128,
                    ScheduleId = 7,
                    StopId = 75,
                }
                );
            //Store 8 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 129,
                    ScheduleId = 8,
                    StopId = 8,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 130,
                    ScheduleId = 8,
                    StopId = 16,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 131,
                    ScheduleId = 8,
                    StopId = 26,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 132,
                    ScheduleId = 8,
                    StopId = 38,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 133,
                    ScheduleId = 8,
                    StopId = 46,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 134,
                    ScheduleId = 8,
                    StopId = 56,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 135,
                    ScheduleId = 8,
                    StopId = 68,
                }
                );
            //Store 9 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 136,
                    ScheduleId = 9,
                    StopId = 9,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 137,
                    ScheduleId = 9,
                    StopId = 17,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 138,
                    ScheduleId = 9,
                    StopId = 27,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 139,
                    ScheduleId = 9,
                    StopId = 39,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 140,
                    ScheduleId = 9,
                    StopId = 47,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 141,
                    ScheduleId = 9,
                    StopId = 57,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 142,
                    ScheduleId = 9,
                    StopId = 69,
                }
                );
            //Store 10 Stops
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 143,
                    ScheduleId = 10,
                    StopId = 10,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 144,
                    ScheduleId = 10,
                    StopId = 18,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 145,
                    ScheduleId = 10,
                    StopId = 28,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 146,
                    ScheduleId = 10,
                    StopId = 40,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 147,
                    ScheduleId = 10,
                    StopId = 48,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 148,
                    ScheduleId = 10,
                    StopId = 58,
                }
                );
            builder.Entity<ScheduleStop>().HasData(
                new ScheduleStop
                {
                    ScheduleStopId = 149,
                    ScheduleId = 10,
                    StopId = 70,
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
