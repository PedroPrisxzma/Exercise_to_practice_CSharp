using IDomain.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Domain.Test
{
    public class SalesTest
    {
        [Fact]
        public void The_State_Sales_Should_Be_In_Processed()
        {
            var sales = new Domain.Sales(string.Empty, null);
            sales.SetUUID( Guid.NewGuid().ToString() );
            Assert.Equal(SalesState.Processed, sales.state);
        }
    }
}
