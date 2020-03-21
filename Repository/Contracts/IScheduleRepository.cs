using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IScheduleRepository : IRepositoryBase<Schedule>
    {
        Schedule GetSchedule(int scheduleId);
        Schedule GetScheduleIncludeAll(int scheduleId);
    }
}
