﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IStopRepository : IRepositoryBase<Stop>
    {
        public Stop GetStop(int stopId);
        public Stop GetStopIncludeAll(int stopId);
    }
}
