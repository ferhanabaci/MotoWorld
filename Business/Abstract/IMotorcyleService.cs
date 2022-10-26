using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMotorcyleService
    {
        IDataResult<List<Motorcycle>> GetAll();
        IDataResult<List<MotorcyleDetailDto>> GetMotorcyleDetails();
        IDataResult<Motorcycle> GetById(int motorcycleId);
        IResult Add(Motorcycle motorcycle);
    }
}
