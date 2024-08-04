using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);

        IDataResult<List<CarImage>> GetByCarId(int carId);
        IResult Add(CarImage carImage, Microsoft.AspNetCore.Http.IFormFile file);
        IResult Update(CarImage carImage, Microsoft.AspNetCore.Http.IFormFile file);
        IResult Delete(CarImage carImage);
    }
}
