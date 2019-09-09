using IDomain.Abstract.Entities;
using IDomain.Abstract.Enums;
using IInfra.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infra
{
    public class SalesRepository : ISalesRepository
    {
        private static IList<ISales> salesList = new List<ISales>();
        public Task<SalesState> CheckStateAsync(string uuid)
        {
            return Task.FromResult(salesList.Where(c => c.UUID == uuid).FirstOrDefault().state);
        }

        public Task<string> SaveAsync(ISales sales)
        {
            var uuid = Guid.NewGuid().ToString();
            sales.SetUUID(uuid);
            return Task.FromResult(uuid); 
        }
    }
}
