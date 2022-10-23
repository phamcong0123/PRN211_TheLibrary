﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category? GetCategoryByID(int categoryID);
    }
}
