using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }

        public IResult Add(Category Category)
        {
            //Business codes
            categoryDal.Add(Category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category Category)
        {
            categoryDal.Delete(Category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IResult Update(Category Category)
        {
            categoryDal.Update(Category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IDataResult<Category> GetById(int CategoryId)
        {
            return new SuccessDataResult<Category>(categoryDal.Get(filter: p => p.CategoryId == CategoryId));
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(categoryDal.GetList().ToList());
        }
    }
}
