using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int CategoryId);
        IDataResult<List<Category>> GetList();

        IResult Add(Category Category);
        IResult Delete(Category Category);
        IResult Update(Category Category);
    }
}
