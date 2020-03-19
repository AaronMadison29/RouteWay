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
    public class StoreController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public StoreController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<Store> Get()
        {
            return _repo.Stores.GetStores();
        }

        [HttpGet("{id:int}")]
        public Store Get(int id)
        {
            var store = _repo.Stores.GetStoreIncludeAll(id);
            return store;
        }
    }
}