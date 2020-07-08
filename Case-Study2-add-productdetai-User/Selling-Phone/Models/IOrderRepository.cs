using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> Gets();
    }
}
