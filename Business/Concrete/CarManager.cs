using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Günlük fiyat 0 dan büyük olmalı");
            }
            else if (car.Description.Length <= 2)
            {
                Console.WriteLine("Araba isim uzunlugu 2 den fazla olmalı");
            }
            else
            {
                Console.WriteLine("Araba eklendi: " + car.Description);
                _carDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllById(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
