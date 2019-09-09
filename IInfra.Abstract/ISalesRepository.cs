using IDomain.Abstract.Entities;
using IDomain.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IInfra.Abstract
{
    public interface ISalesRepository
    {
        Task<string> SaveAsync(ISales sales);
        Task<SalesState> CheckStateAsync(string uUID);
    }
}
