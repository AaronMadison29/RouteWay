using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Repository.Models;
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
        private readonly IConfiguration _config;


        public RoutingService(IConfiguration config)
        {
            _config = config;
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
