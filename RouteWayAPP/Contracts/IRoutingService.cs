using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteWayAPP.Contracts
{
    public interface IRoutingService
    {
        Task LinkEmployeeAccount(Employee employee);
    }
}
