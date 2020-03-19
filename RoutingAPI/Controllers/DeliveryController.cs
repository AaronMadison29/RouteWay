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
    public class DeliveryController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public DeliveryController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        [HttpGet("{id:int}")]
        public Delivery Get(int id)
        {
            var delivery = _repo.Deliveries.GetDelivery(id);
            return delivery;
        }
    }
}