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
    public class ScheduleStopController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public ScheduleStopController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        [HttpGet("{id:int}")]
        public List<ScheduleStop> Get(int id)
        {
            var scheduleStop = _repo.ScheduleStops.GetScheduleStopForScheduleIncludeAll(id);
            return scheduleStop;
        }
    }
}