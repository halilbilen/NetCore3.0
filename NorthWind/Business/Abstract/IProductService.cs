using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int ProductId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int CategoryId);

        IResult Add(Product Product);
        IResult Delete(Product Product);
        IResult Update(Product Product);

        IResult TransactionalOperation(Product product);
    }
}
