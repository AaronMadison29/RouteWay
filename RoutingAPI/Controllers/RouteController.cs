using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public RouteController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        [HttpGet("{id:int}")]
        public Route Get(int id)
        {
            var route = _repo.Routes.GetRouteIncludeAll(id);
            route.RouteStores = _repo.RouteStores.GetRouteStoresForRouteIncludeAll(route.RouteId).ToList();
            return route;
        }
    }
}
