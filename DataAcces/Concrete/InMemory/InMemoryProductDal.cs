using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Bardak",UnitPrice = 15, UnitInStock =15},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Kamera",UnitPrice = 500, UnitInStock =3},
                new Product{ProductId = 3, CategoryId = 2, ProductName = "Telefon",UnitPrice = 1500, UnitInStock =2},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Klavye",UnitPrice = 150, UnitInStock =65},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Fare",UnitPrice = 85, UnitInStock =1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LİNQ - Language Intergrated Query
                                               //tek tek dolaşır(foreach)
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);

            
        }

        public List<Product> GetAll()
        {
            return _products; 
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(p => p.CategoryId == CategoryId).ToList();
            //where >> içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
    }
}
