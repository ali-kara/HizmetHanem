using Business.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System;


namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        readonly ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new DataResult<List<Category>>(categoryDal.GetAll());
        }
    }

}
