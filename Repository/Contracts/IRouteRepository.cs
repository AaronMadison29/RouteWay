﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IRouteRepository : IRepositoryBase<Route>
    {
        Route GetRouteIncludeAll(int routeId);
    }
}
