using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();  //ürünleri listele
        void Add(Product product); //ekleme
        void Update(Product product);  //güncelleme
                                                     // >> update ve delete de LINQ kullanılacak.
        void Delete(Product product); //silme

        List<Product> GetAllByCategory(int CategoryId);  //ürünleri kategoriye göre filtrele

    }
}
