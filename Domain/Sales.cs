using IDomain.Abstract.Entities;
using IDomain.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Domain
{
    public class Sales : ISales
    {
        public SalesState state { get; private set; } = SalesState.InProcess;
        public IEnumerable<IItemsSales> items { get; }
        public string clientUUID { get; }
        public object UUID { get; private set; }

        public Sales(string clientUUID, IEnumerable<IItemsSales> items)
        {
            clientUUID = clientUUID;
            items = items;
        }

        public double Quantity()
        {
            return (from item in items select item.quantity).Sum();
        }

        public void SetUUID(string uuid)
        {
            if(string.IsNullOrWhiteSpace(uuid))
            {
                throw new ArgumentException("uuid can not be null or empty or a white space", nameof(uuid));
            }
            state = SalesState.Processed;
            UUID = uuid;
        }

        public double Total()
        {
            return items.Sum(c => c.TotalPrice());
        }
    }
}
