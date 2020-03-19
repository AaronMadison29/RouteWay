using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IScheduleStopRepository : IRepositoryBase<ScheduleStop>
    {
        public List<ScheduleStop> GetScheduleStopForScheduleIncludeAll(int routeId);
        public List<ScheduleStop> GetScheduleStopForStopIncludeAll(int storeId);
    }
}
