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
        private readonly IPlaceService _placeService;
        private readonly IDistanceMatrixService _distanceMatrixService;

        public EmployeeController(IRoutingService routingService, IPlaceService placeService, IDistanceMatrixService distanceMatrixService)
        {
            _routingService = routingService;
            _placeService = placeService;
            _distanceMatrixService = distanceMatrixService;
        }

        public async Task<ActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = await _routingService.GetEmployee(userId);
            ViewBag.UserEmployeeId = employee.EmployeeId;
            var scheduleStops = await _routingService.GetScheduleStopsForSchedule(employee.Route.ScheduleId);
            employee.Route.Schedule.ScheduleStops = SortByTime(FilterScheduleForToday(scheduleStops));
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

            ViewBag.StoreInfo = await _placeService.GetPlaceInfo(store.PlaceId);
            ViewBag.Employees = await _routingService.GetEmployees();

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
            employee.Route.Schedule.ScheduleStops = await _routingService.GetScheduleStopsForSchedule(employee.Route.ScheduleId);
            employee.Route.RouteStores = await _routingService.GetRouteStores(employee.RouteId);

            ViewBag.Stores = await _routingService.GetStores();

            return View(employee);
        }

        public List<ScheduleStop> FilterScheduleForToday(List<ScheduleStop> scheduleStops)
        {
            return scheduleStops.Where(ss => ss.Stop.DayOfWeek == DayOfWeek.Monday).ToList();
            //return scheduleStops.Where(ss => ss.Stop.DayOfWeek == DateTime.Now.DayOfWeek).ToList();
        }

        public List<ScheduleStop> SortByTime(List<ScheduleStop> scheduleStops)
        {
            var timedStops = scheduleStops.Where(ss => ss.Stop.DeliveryId != null).ToList();
            timedStops = timedStops.OrderBy(ss => ss.Stop.Delivery.DeliveryTime).ToList();
            var untimedStops = scheduleStops.Where(ss => ss.Stop.DeliveryId == null).ToList();

            var sortedStops = new List<ScheduleStop>();
            if(untimedStops.Count == 0)
            {
                return timedStops;
            }
            for(int i = 0; i < timedStops.Count; i++)
            {
                if (untimedStops.Count == 0)
                {
                    sortedStops.AddRange(timedStops.GetRange(i, timedStops.Count - 1 - i + 1));
                    break;
                }
                if (i == 0)
                {
                    if (timedStops[i].Stop.Delivery.DeliveryTime > new TimeSpan(6, 45, 0))
                    {
                        var timeBetweenStops = (timedStops[i].Stop.Delivery.DeliveryTime - new TimeSpan(6, 0, 0)).TotalMinutes;
                        int merchStopsInTimeAvailable = Convert.ToInt32(Math.Floor(timeBetweenStops / 45));
                        for (int j = 0; j < merchStopsInTimeAvailable; j++)
                        {
                            if(untimedStops.Count == 0)
                            {
                                break;
                            }
                            var closestStop = FindClosestStop(timedStops[i], untimedStops);
                            untimedStops.Remove(closestStop);
                            sortedStops.Add(closestStop);
                        }
                        sortedStops.Add(timedStops[i]);
                    }
                    else
                    {
                        sortedStops.Add(timedStops[i]);
                    }
                }
                else
                {
                    if (timedStops[i].Stop.Delivery.DeliveryTime > timedStops[i - 1].Stop.Delivery.DeliveryTime + new TimeSpan(0, timedStops[i - 1].Stop.Delivery.CaseCount + 45, 0))
                    {
                        var timeBetweenStops = (timedStops[i].Stop.Delivery.DeliveryTime - new TimeSpan(6, 0, 0)).TotalMinutes;
                        int merchStopsInTimeAvailable = Convert.ToInt32(Math.Floor(timeBetweenStops / 45));
                        for (int j = 0; j < merchStopsInTimeAvailable; j++)
                        {
                            if (untimedStops.Count == 0)
                            {
                                break;
                            }
                            var closestStop = FindClosestStop(timedStops[i], untimedStops);
                            untimedStops.Remove(closestStop);
                            sortedStops.Add(closestStop);
                        }
                        sortedStops.Add(timedStops[i]);
                    }
                    else
                    {
                        sortedStops.Add(timedStops[i]);
                    }
                }
                if (i == timedStops.Count - 1 && untimedStops.Count != 0)
                {
                    sortedStops.AddRange(untimedStops);
                    break;
                }
            }

            return sortedStops;
        }

        public ScheduleStop FindClosestStop(ScheduleStop currentStop, List<ScheduleStop> untimedStops)
        {
            var closestStop = (untimedStops[0],100000000000);
            foreach(var scheduleStop in untimedStops)
            {
                var distance = _distanceMatrixService.GetDistanceBetweenTwoStores(currentStop.Stop.Store, scheduleStop.Stop.Store).Result.rows[0].elements[0].distance.value;
                if(distance < closestStop.Item2)
                {
                    closestStop.Item1 = scheduleStop;
                    closestStop.Item2 = distance;
                }
            }
            return closestStop.Item1;
        }
    }
}