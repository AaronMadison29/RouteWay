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
    }
}
