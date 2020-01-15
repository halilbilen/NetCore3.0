using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        public void Add(Product Product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product Product)
        {
            throw new NotImplementedException();
        }

        public Product GetById(Product ProductId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetListByCategory(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
