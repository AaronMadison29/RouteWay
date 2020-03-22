using RouteWayAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RouteWayAPP.Models.DistanceMatrix;

namespace RouteWayAPP.Contracts
{
    public interface IDistanceMatrixService
    {
        public Task<Rootobject> GetDistanceBetweenTwoStores(Store store1, Store store2);
    }
}
