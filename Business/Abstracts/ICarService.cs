using Core.Utilities.Results;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);


        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrand(int id);
        IDataResult<List<Car>> GetAllByColor(int id);
        IDataResult<List<Car>> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetAllByColorAndBrand(int colorId, int brandId);


        IDataResult<List<CarDetailDto>> GetCarDetail();
        IDataResult<CarDetailDto> GetCarDetailId(int id);

    }
}
