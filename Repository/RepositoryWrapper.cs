﻿using Repository.Contracts;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IEmployeeRepository _employee;
        private IRouteRepository _route;
        private IStoreRepository _store;
        private IScheduleRepository _schedule;
        private IStopRepository _stop;
        private IDeliveryRepository _delivery;
        private IRouteStoreRepository _routeStore;
        private IScheduleStopRepository _scheduleStop;
        public IEmployeeRepository Employees
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new EmployeeRepository(_context);
                }
                return _employee;
            }
        }
        public IRouteRepository Routes
        {
            get
            {
                if (_route == null)
                {
                    _route = new RouteRepository(_context);
                }
                return _route;
            }
        }
        public IStoreRepository Stores
        {
            get
            {
                if (_store == null)
                {
                    _store = new StoreRepository(_context);
                }
                return _store;
            }
        }
        public IScheduleRepository Schedules
        {
            get
            {
                if (_schedule == null)
                {
                    _schedule = new ScheduleRepository(_context);
                }
                return _schedule;
            }
        }
        public IStopRepository Stops
        {
            get
            {
                if (_stop == null)
                {
                    _stop = new StopRepository(_context);
                }
                return _stop;
            }
        }
        public IDeliveryRepository Deliveries
        {
            get
            {
                if (_delivery == null)
                {
                    _delivery = new DeliveryRepository(_context);
                }
                return _delivery;
            }
        }
        public IRouteStoreRepository RouteStores
        {
            get
            {
                if (_routeStore == null)
                {
                    _routeStore = new RouteStoreRepository(_context);
                }
                return _routeStore;
            }
        }
        public IScheduleStopRepository ScheduleStops
        {
            get
            {
                if (_scheduleStop == null)
                {
                    _scheduleStop = new ScheduleStopRepository(_context);
                }
                return _scheduleStop;
            }
        }
        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
