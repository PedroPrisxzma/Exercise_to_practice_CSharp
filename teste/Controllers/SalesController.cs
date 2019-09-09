using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using infra;
using IService.Abstract;
using Microsoft.AspNetCore.Mvc;
using Service;

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
        [HttpPost]
        public async Task<ActionResult> Post()
        {
            await salesService.ProcessAsync(null);
            return Ok();
        }
    }
}
