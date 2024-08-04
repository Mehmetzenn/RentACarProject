using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.cars
                             join b in context.brands
                             on c.BrandId equals b.BrandId
                             join co in context.colors
                             on c.ColorId equals co.ColorId
                             join i in context.carimages
                             on c.Id equals i.CarId
                             select new CarDetailDto { 
                             BrandName = b.BrandName,
                             CarName = c.CarName,
                             ColorName = co.ColorName, 
                             DailyPrice = c.DailyPrice, 
                             CarDescription=c.CarDescription, 
                             CarId=c.Id, 
                             ImagePath = i.ImagePath,       
                             ModelYear=c.ModelYear};
                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetailId(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = (from c in context.cars
                              join b in context.brands
                              on c.BrandId equals b.BrandId
                              join g in context.colors
                              on c.ColorId equals g.ColorId
                              join i in context.carimages
                             on c.Id equals i.CarId into images
                              from img in images.DefaultIfEmpty()
                              where c.Id == id
                              select new CarDetailDto
                              {
                                  CarId = c.Id,
                                  CarName = c.CarName,
                                  BrandName = b.BrandName,
                                  ColorName = g.ColorName,
                                  ModelYear = c.ModelYear,
                                  DailyPrice = c.DailyPrice,
                                  CarDescription = c.CarDescription,
                                  ImagePath = (img != null) ? img.ImagePath : null,
                              }).FirstOrDefault();
                return result;

                //CarName, BrandName, ColorName, DailyPrice , ModelYear , CarId , ImagePath

            }
        }
    }
}
