using RouteWayAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RouteWayAPP.Models.PlaceInfo;

namespace RouteWayAPP.Contracts
{
    public interface IPlaceService
    {
        Task<Rootobject> GetPlaceInfo(string placeId);
    }
}
