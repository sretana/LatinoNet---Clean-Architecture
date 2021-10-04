﻿using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly LatinoNetContext Context;

        public ProductRepository(LatinoNetContext context) =>
            Context = context;

        public IEnumerable<Product> AllProducts()
        {
            return Context.Product;
        }

        public void CreateProduct(Product product)
        {
            Context.Add(product);
        }
    }
}
