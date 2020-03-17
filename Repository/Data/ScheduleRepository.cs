using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Data
{
    public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Schedule GetSchedule(int scheduleId) => FindByCondition(c => c.ScheduleId == scheduleId).SingleOrDefault();
    }
}
