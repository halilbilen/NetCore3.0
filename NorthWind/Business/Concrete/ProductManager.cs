using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public void Add(Product Product)
        {
            //Business codes
            _productDal.Add(Product);
        }

        public void Delete(Product Product)
        {
            _productDal.Delete(Product);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(filter: p => p.ProductId == productId);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList().ToList();
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(filter: p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product Product)
        {
            _productDal.Update(Product);
        }
    }
}
