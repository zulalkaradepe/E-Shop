﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class CategoryRepository : GenericRepository<Category>
    {
        private DataContext db = new DataContext();

        public List<Product> CategoryDetails(int id)
        {
            return db.Products.Where(x => x.CategoryId == id).ToList();
        }
    }
}
