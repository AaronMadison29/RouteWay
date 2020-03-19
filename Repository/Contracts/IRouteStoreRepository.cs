using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IRouteStoreRepository : IRepositoryBase<RouteStore>
    {
        public List<RouteStore> GetRouteStoresForRouteIncludeAll(int routeId);
        public List<RouteStore> GetRouteStoresForStoreIncludeAll(int storeId);
    }
}
