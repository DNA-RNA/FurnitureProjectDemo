using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
         new Product{ProductId= 101,CategoryId=1, ProductName="Rolf Koltuk Takımı",ColorId=2,BrandId=1,UnitPrice=15000,UnitsInStock=15 },
         new Product{ProductId= 102,CategoryId=2, ProductName="Vels Yemek Odası Takımı",ColorId=3,BrandId=2,UnitPrice=8000,UnitsInStock=10 },
         new Product{ProductId= 103,CategoryId=3, ProductName="Armony Yatak Odası Takımı",ColorId=1,BrandId=1,UnitPrice=12000,UnitsInStock=25 },
         new Product{ProductId= 104,CategoryId=4, ProductName="Rasalme Genç Odası Takımı",ColorId=3,BrandId=2,UnitPrice=12000,UnitsInStock=5 }
            };
           
        }
        public void Add(Product product)
        {
            Product productToAdd = _products.SingleOrDefault(p=> p.ProductId== product.ProductId);
           
            _products.Add(productToAdd);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId==product.ProductId && p.CategoryId==product.CategoryId);
            _products.Remove(productToDelete);
        }
           

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.Sizes = product.Sizes;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
