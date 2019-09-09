using IDomain.Abstract.Entities;
using IDomain.Abstract.Enums;
using IInfra.Abstract;
using IService.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SalesService : ISalesService
    {
        public readonly ISalesRepository salesRepository;
        public SalesService(ISalesRepository salesRepository)
        {
            this.salesRepository = salesRepository;
        }
        public Task<SalesState> CheckStateAsync(string UUID)
        {
            return salesRepository.CheckStateAsync(UUID);
        }

        public async Task<SalesState> ProcessAsync(ISales sales)
        {
            var uuid = await salesRepository.SaveAsync(sales);
            return string.IsNullOrEmpty(uuid) ? SalesState.InProcess : SalesState.Processed;
        }
    }
}
