﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
        IDataResult<User> GetByUserId(int userId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IResult EditProfil(User user, string password);
        IDataResult<User> GetUserByEmail(string email);
        IDataResult<User> GetById(int id);
    }
}
