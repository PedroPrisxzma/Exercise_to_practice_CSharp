using IDomain.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ItemSales : IItemsSales
    {
        public string productUUID { get; }
        public double unitPrice { get; }
        public double quantity { get; }
        public ItemSales(string ProductUUID, double UnitPrice, double Quantity)
        {
            unitPrice = UnitPrice;
            productUUID = ProductUUID;
            quantity = Quantity;
        }
        public double TotalPrice()
        {
            return unitPrice * quantity;
        }
    }
}
