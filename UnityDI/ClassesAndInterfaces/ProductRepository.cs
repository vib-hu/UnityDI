﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDI.ClassesAndInterfaces
{
    public class ProductRepository : IProductRepository
    {
        IDataContext _dataContext;
        String _testString;

        public ProductRepository(IDataContext DataContext, string TestString)
        {
            _dataContext = DataContext;
            _testString = TestString;
        }

        public void AddProduct(Product product)
        {
            
        }
    }
}
