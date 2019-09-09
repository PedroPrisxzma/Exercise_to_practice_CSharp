using System;
using System.Collections.Generic;
using System.Text;

namespace IDomain.Abstract.Entities
{
    public interface IItemsSales
    {
        string productUUID { get; }

        double unitPrice { get; }
        double quantity { get; }
        double TotalPrice();
    }
}
