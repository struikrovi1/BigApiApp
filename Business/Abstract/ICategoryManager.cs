﻿using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        List<Category> GetAll();
        Category GetById(int id);   
        void Add(CategoryDTO category);

        void Remove(int id);
        void Update(Category category);

    }
}
