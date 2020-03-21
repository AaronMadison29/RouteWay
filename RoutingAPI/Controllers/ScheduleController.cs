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
    public class ScheduleController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public ScheduleController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        [HttpGet("{id:int}")]
        public Schedule Get(int id)
        {
            var schedule = _repo.Schedules.GetScheduleIncludeAll(id);
            return schedule;
        }
    }
}