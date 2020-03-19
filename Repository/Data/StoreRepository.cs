using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class StoreRepository : RepositoryBase<Store>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Store GetStore(int storeId) => FindByCondition(c => c.StoreId == storeId).SingleOrDefault();
        public Store GetStoreIncludeAll(int storeId) => FindByCondition(c => c.StoreId == storeId).Include(s => s.Schedule).Include("RouteStores").Include("RouteStores.Route").SingleOrDefault();
        public List<Store> GetStores() => FindAll().ToList();
    }
}
