using Business.Abstract;
using DataAcces.Abstract;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //manager >> iş katmanının somut sınıfı
    //bir iş sınıfı başka sınıfları new leyemez bunun yerine injection yaparız!!!
    //productmanager new lendiği zaman bana bir tane ıproductdal referansı ver.
    // business ın tek bildiği şey ıproductdal bu her şey olabilir(x,y,z = veri yöntemi)
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetAll()
        {
            //İş kodları
            return _productDal.GetAll();
        }
    }
}
