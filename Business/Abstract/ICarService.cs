﻿using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllById(int id);
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
