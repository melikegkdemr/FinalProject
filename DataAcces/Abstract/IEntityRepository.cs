using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Abstract
{
    //generic constarint - kısıtlama 
    //where T: T ne olabilir?
    //class >> referans tip
    //IEntity >> IEntity olabilir veya IEntity implemente eden nesne ler yazılabilir.
    //new() >> new lenebilir >> Interface ler newlenemez.

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
                                              //filtre vermeyedebilirsin.
        List<T> GetAll(Expression<Func<T,bool>> filter = null);  //ürünleri listele -  expression filtreleme yapmamı sağladı.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity); //ekleme
        void Update(T entity);  //güncelleme
                                       // >> update ve delete de LINQ kullanılacak.
        void Delete(T entity); //silme
    }
}
