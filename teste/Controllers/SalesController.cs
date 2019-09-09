using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using infra;
using IService.Abstract;
using Microsoft.AspNetCore.Mvc;
using Service;
using Vendas.Models;

namespace teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        ISalesService salesService;
        public SalesController()
        {
            salesService = new SalesService(new SalesRepository());
        }
        [HttpGet]
        public async Task<ActionResult> Get(string uuid)
        {
            var state = await salesService.CheckStateAsync(uuid);
            return Ok(state);
        }

        [HttpPost]
        public async Task<ActionResult> Post(SalesModel salesModel )
        {
            var itemSales = salesModel.itemSalesModels.Select(s => new ItemSales(s.productUUID, s.unitPrice, s.quantity));
            var sales = new Sales(salesModel.clientUUID, itemSales);
            await salesService.ProcessAsync(sales);
            return Ok();
        }
    }
}
