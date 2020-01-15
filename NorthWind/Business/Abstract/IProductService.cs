using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product GetById(Product ProductId);
        List<Product> GetList();
        List<Product> GetListByCategory(int CategoryId);

        void Add(Product Product);
        void Delete(Product Product);
        void Update(Product Product);
    }
}
