using Nortwind.Business.Concrete;
using NortwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProductByCatagory(int catagoryId);
        List<Product> GetProductByProductName(string ProductName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
