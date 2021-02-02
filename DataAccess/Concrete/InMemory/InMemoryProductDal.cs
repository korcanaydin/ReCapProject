using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{CarId=1,BrandId=1,ModelYear=2015,DailyPrice=125000, Description="az kullanılmış" },
                new Product{CarId=2,BrandId=2,ModelYear=2012,DailyPrice=115000, Description="az kullanılmış" },
                new Product{CarId=3,BrandId=3,ModelYear=2013,DailyPrice=14500, Description="az kullanılmış" },
                new Product{CarId=4,BrandId=4,ModelYear=2014,DailyPrice=18000, Description="az kullanılmış" },
                new Product{CarId=5,BrandId=5,ModelYear=2019,DailyPrice=12700, Description="az kullanılmış" }


            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void GetById(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            Product productToDelete =_products.SingleOrDefault(p => p.CarId == product.CarId);
            _products.Remove(productToDelete);
        
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        
        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.CarId == product.CarId);
            productToUpdate.CarId = product.CarId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
        }

        
    }
}
