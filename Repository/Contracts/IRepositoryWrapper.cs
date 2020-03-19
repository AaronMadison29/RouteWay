using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IRepositoryWrapper
    {
        IEmployeeRepository Employees { get; }
        IRouteRepository Routes { get; }
        IScheduleRepository Schedules { get; }
        IStopRepository Stops { get; }
        IStoreRepository Stores { get; }
        IDeliveryRepository Deliveries { get; }
        IRouteStoreRepository RouteStores { get; }
        IScheduleStopRepository ScheduleStops { get; }
        void Save();
    }
}
