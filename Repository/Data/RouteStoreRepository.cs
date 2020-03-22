using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Data
{
    public class RouteStoreRepository : RepositoryBase<RouteStore>, IRouteStoreRepository
    {
        public RouteStoreRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public List<RouteStore> GetRouteStoresForRouteIncludeAll(int routeId) => FindByCondition(rs => rs.RouteId == routeId).ToList();
        public List<RouteStore> GetRouteStoresForStoreIncludeAll(int storeId) => FindByCondition(rs => rs.StoreId == storeId).ToList();
    }
}
