using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMotorcyleDal : EfEntityRepositoryBase<Motorcycle, DataContext>, IMotorcyleDal
    {
        public List<MotorcyleDetailDto> GetMotorcyleDetails()
        {
            using (DataContext context = new DataContext())
            {
                var result = from m in context.Motorcycles
                             join b in context.Brands
                             on m.BrandId equals b.BrandId
                             select new MotorcyleDetailDto
                             {
                                 MotorcycleId = m.MotorcycleId,
                                 MotorcyleName = m.MotorcyleName,
                                 BrandId = b.BrandId
                             };

                return result.ToList();

            }     
        }
    }
}
