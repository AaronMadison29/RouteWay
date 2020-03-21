using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RouteWayAPP.Contracts;
using RouteWayAPP.Models;

namespace RouteWayAPP.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRoutingService _routingService;

        public EmployeeController(IRoutingService routingService)
        {
            _routingService = routingService;
        }

        public async Task<ActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = await _routingService.GetEmployee(userId);
            ViewBag.UserEmployeeId = employee.EmployeeId;
            var scheduleStops = await _routingService.GetScheduleStopsForSchedule(employee.Route.ScheduleId);
            employee.Route.Schedule.ScheduleStops = FilterScheduleForToday(scheduleStops);
            return View(employee);
        }

        public async Task<ActionResult> StopDetails(int stopId)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userEmployee = await _routingService.GetEmployee(userId);
            ViewBag.UserEmployeeId = userEmployee.EmployeeId;


            var stop = await _routingService.GetStop(stopId);
            ViewBag.Employee = await _routingService.GetEmployee(stop.EmployeeId);
            ViewBag.Store = await _routingService.GetStore(stop.StoreId);
            return View(stop);
        }
        public async Task<ActionResult> StoreDetails(int storeId)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userEmployee = await _routingService.GetEmployee(userId);
            ViewBag.UserEmployeeId = userEmployee.EmployeeId;


            var store = await _routingService.GetStore(storeId);
            store.Schedule.ScheduleStops = await _routingService.GetScheduleStopsForSchedule(store.Schedule.ScheduleId);
            return View(store);
        }

        public async Task<ActionResult> DeliveryDetails(int deliveryId)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userEmployee = await _routingService.GetEmployee(userId);
            ViewBag.UserEmployeeId = userEmployee.EmployeeId;


            var delivery = await _routingService.GetDelivery(deliveryId);
            ViewBag.Driver = await _routingService.GetEmployee(delivery.DriverId);
            return View(delivery);
        }

        public async Task<ActionResult> EmployeeDetails(int employeeId)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userEmployee = await _routingService.GetEmployee(userId);
            ViewBag.UserEmployeeId = userEmployee.EmployeeId;

            var employee = await _routingService.GetEmployee(employeeId);
            return View(employee);
        }

        public List<ScheduleStop> FilterScheduleForToday(List<ScheduleStop> scheduleStops)
        {
            return scheduleStops.Where(ss => ss.Stop.DayOfWeek == DayOfWeek.Monday).ToList();
            //return scheduleStops.Where(ss => ss.Stop.DayOfWeek == DateTime.Now.DayOfWeek).ToList();
        }
    }
}