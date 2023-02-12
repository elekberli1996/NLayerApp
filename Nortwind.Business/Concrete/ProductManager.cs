using FluentValidation;
using Nortwind.Business.Abstract;
using Nortwind.Business.Utilities;
using Nortwind.Business.ValidationRules.FluentValidation;
using Nortwind.DataAccess.Abstract;
using NortwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Business cok is katmani
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {

            _productDal = productDal;
        }

        public void Add(Product product)
        {
           
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (Exception)
            {

                throw new Exception("silme gerceklesmedi");
            }
            
        }

        public List<Product> GetProductByCatagory(int catagoryId)
        {
            return _productDal.GetAll(p => p.CategoryID == catagoryId);
        }

        public List<Product> GetProductByProductName(string ProductName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(ProductName.ToLower()));
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
        //yanliz veri erisim katmani kullanilir
        // D dependenci inversion bir katman diyer katmani newleye bilmez bagilmi olursun
        // Open close prinsipi bi ekleme yapiliginda koldlarda deyisiklik  yapmamalisin
        //Code Smell
        // eyer bir class ciplak duruyorsa Code Smel
    }
}
