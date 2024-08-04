using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new  RentACarContext())
            {
                var result = from r in context.rentals
                             join c in context.cars
                             on r.CarId equals c.Id
                             join u in context.users
                             on r.CustomerId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarName=c.CarName,
                                 CustomerName = u.FirstName+ " "+u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };
                                
                return result.ToList();
            }
        }
    }
}
