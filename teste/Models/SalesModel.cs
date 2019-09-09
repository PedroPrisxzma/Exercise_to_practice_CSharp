using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class SalesModel
    {
        public string clientUUID { get; set; }
        public List<ItemSalesModel> itemSalesModels { get; set; }

    }

    public class ItemSalesModel
    {
        public string productUUID { get; set; }
        public double unitPrice { get; set; }
        public double quantity { get; set; }
    }
}
