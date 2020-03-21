using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RouteWayAPP.Models;
using RouteWayAPP.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RouteWayAPP.Services
{
    public class RoutingService : IRoutingService
    {
        public async Task<List<Employee>> GetEmployees()
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44339/api/Employee/";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Employee>>(json);
            }
            return null;
        }
        public async Task<Employee> GetEmployee(string userId)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44339/api/Employee/" + userId;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Employee>(json);
            }
            return null;
        }
        public async Task<Employee> GetEmployee(int employeeId)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44339/api/Employee/" + employeeId;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Employee>(json);
            }
            return null;
        }
        public async Task<Store> GetStore(int storeId)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44339/api/Store/" + storeId;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Store>(json);
            }
            return null;
        }
        public async Task<Delivery> GetDelivery(int deliveryId)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44339/api/Delivery/" + deliveryId;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Delivery>(json);
            }
            return null;
        }
        public async Task<Stop> GetStop(int stopId)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44339/api/Stop/" + stopId;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Stop>(json);
            }
            return null;
        }
        public async Task<List<ScheduleStop>> GetScheduleStopsForSchedule(int scheduleId)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44339/api/ScheduleStop/" + scheduleId;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<ScheduleStop>>(json);
            }
            return null;
        }
        public async Task<List<ScheduleStop>> GetScheduleStopsForToday(int scheduleId)
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44339/api/ScheduleStop/" + scheduleId;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<ScheduleStop>>(json);
            }
            return null;
        }

        public async Task LinkEmployeeAccount(Employee employee)
        {
            string url = "https://localhost:44339/api/Employee/Link";
            var json = JsonConvert.SerializeObject(employee);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            HttpResponseMessage response = await client.PutAsync(url, data);

        }
    }
}
