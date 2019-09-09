using IDomain.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDomain.Abstract.Entities
{
    public interface ISales
    {
        SalesState state { get; }
        IEnumerable<IItemsSales> items { get; }
        string clientUUID { get; }
        object UUID { get; }

        double Total();
        double Quantity();
        void SetUUID(string uuid);
    }
}
