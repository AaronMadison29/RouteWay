using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IStoreRepository : IRepositoryBase<Store>
    {
        Store GetStore(int storeId);
        public Store GetStoreIncludeAll(int storeId);
        public List<Store> GetStores();
    }
}
