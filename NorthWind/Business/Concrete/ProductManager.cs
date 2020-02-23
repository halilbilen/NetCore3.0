﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;

        public ProductManager(IProductDal _productDal)
        {
            productDal = _productDal;
        }

        [ValidationAspect(typeof(ProductValidator), Priority = 2)]
        public IResult Add(Product Product)
        {
            productDal.Add(Product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product Product)
        {
            productDal.Delete(Product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IResult Update(Product Product)
        {
            productDal.Update(Product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(productDal.Get(filter: p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(productDal.GetList(filter: p => p.CategoryId == categoryId).ToList());
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Product product)
        {
            productDal.Update(product);
            //productDal.Add(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
