using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Models;

namespace RoutingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteStoreController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public RouteStoreController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        [HttpGet("{routeId:int}")]
        public List<RouteStore> Get(int routeId)
        {
            var routeStore = _repo.RouteStores.GetRouteStoresForRouteIncludeAll(routeId);
            return routeStore;
        }
    }
}