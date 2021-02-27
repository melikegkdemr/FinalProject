﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{

    // iş katmanında kullanacağımız servis operasyonları
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
