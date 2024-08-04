using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesControllers : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesControllers  (ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        //[HttpPost("add")]
        //public IActionResult Add([FromForm] IFormFile file, [FromForm] CarImage carImage)
        //{
        //    var result = _carImageService.Add(carImage, file);

        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpPost("update")]
        //public IActionResult Update([FromForm] CarImage carImage, [FromForm] IFormFile file)
        //{
        //    var result = _carImageService.Update(carImage, file);

        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpPost("delete")]
        //public IActionResult Delete(CarImage carImage)
        //{
        //    var deleteImage = _carImageService.GetById(carImage.Id).Data;
        //    var result = _carImageService.Delete(carImage);

        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int carId)
        {
            var result = _carImageService.GetByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId)
        {
            var result = _carImageService.GetByCarId(imageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
