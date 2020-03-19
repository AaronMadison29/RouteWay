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
    public class StopController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public StopController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        [HttpGet("{id:int}")]
        public Stop Get(int id)
        {
            var stop = _repo.Stops.GetStop(id);
            return stop;
        }
    }
}