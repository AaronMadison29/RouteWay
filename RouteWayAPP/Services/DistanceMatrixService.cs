using Newtonsoft.Json;
using RouteWayAPP.Contracts;
using RouteWayAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static RouteWayAPP.Models.DistanceMatrix;

namespace RouteWayAPP.Services
{
    public class DistanceMatrixService : IDistanceMatrixService
    {
        public async Task<Rootobject> GetDistanceBetweenTwoStores(Store origin, Store destination)
        {
            HttpClient client = new HttpClient();
            string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={origin.Lat},{origin.Long}&destinations={destination.Lat},{destination.Long}&key=" + KeyVariables.GoogleKey;
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Rootobject>(json);
            }
            return null;
        }
    }
}
