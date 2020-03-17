﻿using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Data
{
    public class RouteRepository : RepositoryBase<Route>, IRouteRepository
    {
        public RouteRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Route GetRoute(int routeId) => FindByCondition(c => c.RouteId == routeId).SingleOrDefault();
    }
}