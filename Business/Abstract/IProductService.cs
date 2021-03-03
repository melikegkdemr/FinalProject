using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{

    // iş katmanında kullanacağımız servis operasyonları
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitsPrice(decimal min,decimal max);
        List<ProductDetailDto> GetProductDetails();
    }
}
