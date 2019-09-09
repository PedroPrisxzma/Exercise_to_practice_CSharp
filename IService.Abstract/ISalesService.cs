using IDomain.Abstract.Entities;
using IDomain.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IService.Abstract
{
    public interface ISalesService
    {
        Task<SalesState> ProcessAsync(ISales sales);
        Task<SalesState> CheckStateAsync(string UUID);

    }
}
