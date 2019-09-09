using IDomain.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ItemSales : IItemsSales
    {
        string productUUID { get; }
        double unitPrice { get; }
        double quantity { get; }
        double TotalPrice()
        {
            return unitPrice * quantity;
        }
    }
}
