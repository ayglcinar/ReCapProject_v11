using System;
using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        //List<Car> GetAll();
        //IDataResult<List<Core.Entities.Concrete.User>> GetAll();
        IResult Add(Core.Entities.Concrete.User user);
        //IResult Update(Core.Entities.Concrete.User user);
        //IResult Delete(Core.Entities.Concrete.User user);

        IDataResult<List<OperationClaim>> GetClaims(Core.Entities.Concrete.User user);
        IDataResult<Core.Entities.Concrete.User> GetByMail(string email);
    }
}
