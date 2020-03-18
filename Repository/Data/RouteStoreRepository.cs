using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class RouteStoreRepository : RepositoryBase<RouteStore>, IRouteStoreRepository
    {
        public RouteStoreRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
