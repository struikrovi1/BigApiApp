using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(CategoryDTO category)
        {
            Category cat = new()
            {
                Id = category.Id,
                Name = category.Name,
                IsDeleted = category.IsDeleted,
                IsFeatured = category.IsFeatured,
                SeqNo = category.SeqNo,
                ParentCategoryId = category.ParentCategoryId,
                ModifiedOn = DateTime.Now,
                PublishDate = DateTime.Now,


            };
            _categoryDal.Add(cat); 

        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll(null);
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
