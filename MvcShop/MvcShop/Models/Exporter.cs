using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcShop.Models
{
    public interface Exporter
    {
        void export(List<Product> productList);
    }
}
