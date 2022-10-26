using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MotorcyleManager : IMotorcyleService
    {
        IMotorcyleDal _motorcyleDal;
        public MotorcyleManager(IMotorcyleDal motorcyleDal)
        {
            _motorcyleDal = motorcyleDal;
        }

        public IResult Add(Motorcycle motorcycle)
        {
            if (motorcycle.MotorcyleName.Length < 2)
                return new ErrorResult(Messages.MotorcycleNameInvalid);

            _motorcyleDal.Add(motorcycle);
            return new Result(true, Messages.MotorcycleAdded); 
        }

        public IDataResult<List<Motorcycle>> GetAll()
        {
            if(DateTime.Now.Hour  == 22)
            {
                return new ErrorDataResult<List<Motorcycle>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Motorcycle>>(_motorcyleDal.GetAll(),Messages.MotorcycleListed);
        }

        public IDataResult<Motorcycle> GetById(int motorcycleId)
        {
            return new SuccessDataResult<Motorcycle>(_motorcyleDal.Get(m => m.MotorcycleId == motorcycleId));
        }

        public IDataResult<List<MotorcyleDetailDto>> GetMotorcyleDetails()
        {
            
            return new SuccessDataResult<List<MotorcyleDetailDto>>(_motorcyleDal.GetMotorcyleDetails());
        }
    }
}
