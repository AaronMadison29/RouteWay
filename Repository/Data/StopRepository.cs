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
    public class StopRepository : RepositoryBase<Stop>, IStopRepository
    {
        public StopRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Stop GetStop(int stopId) => FindByCondition(c => c.StopId == stopId).SingleOrDefault();
        public Stop GetStopIncludeAll(int stopId) => FindByCondition(c => c.StopId == stopId).Include(s => s.Delivery).SingleOrDefault();
    }
}
