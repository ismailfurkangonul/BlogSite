﻿using AriBilgi.Blog.Data.Abstract;
using AriBilgi.Blog.Entities.Concrete;
using AriBilgi.Blog.Shared.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.Blog.Data.Concrete.EntityFramework.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {

        }
    }
}
