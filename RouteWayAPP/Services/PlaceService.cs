﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RouteWayAPP.Contracts;
using RouteWayAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RouteWayAPP.Services
{
    public class PlaceService : IPlaceService
    {
        public async Task<Rootobject> GetPlaceInfo(string placeId)
        {
            HttpClient client = new HttpClient();
            string url = $"https://maps.googleapis.com/maps/api/place/details/json?place_id=" + placeId + "&fields=rating,formatted_phone_number&key=" + KeyVariables.GoogleKey;
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
