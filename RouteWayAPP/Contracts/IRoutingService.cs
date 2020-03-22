using RouteWayAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteWayAPP.Contracts
{
    public interface IRoutingService
    {
        Task<Employee> GetEmployee(string userId);
        Task<Employee> GetEmployee(int employeeId);
        Task<List<Employee>> GetEmployees();
        Task<Store> GetStore(int storeId);
        Task<List<Store>> GetStores();
        Task<Stop> GetStop(int stopId);
        Task<Delivery> GetDelivery(int deliveryId);
        Task<Schedule> GetSchedule(int scheduleId);
        Task<List<RouteStore>> GetRouteStores(int scheduleId);
        Task<List<ScheduleStop>> GetScheduleStopsForSchedule(int id);
        Task LinkEmployeeAccount(Employee employee);
    }
}
