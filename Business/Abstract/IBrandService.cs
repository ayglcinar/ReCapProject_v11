using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IBrandService
    {
        //List<Car> GetAll();
        IDataResult<List<Brand>> GetAll();
       
        IDataResult<Brand> GetById(int brandId);

        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
    }
}
