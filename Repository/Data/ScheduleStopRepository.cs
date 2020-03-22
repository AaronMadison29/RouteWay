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
    public class ScheduleStopRepository : RepositoryBase<ScheduleStop>, IScheduleStopRepository
    {
        public ScheduleStopRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public List<ScheduleStop> GetScheduleStopForScheduleIncludeAll(int scheduleId) => FindByCondition(rs => rs.ScheduleId == scheduleId).Include(rs => rs.Stop).Include("Stop.Store").Include("Stop.Delivery").ToList();
        public List<ScheduleStop> GetScheduleStopForStopIncludeAll(int stopId) => FindByCondition(rs => rs.StopId == stopId).Include(rs => rs.Schedule).ToList();
    }
}
