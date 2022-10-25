using Business.Abstract;
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
        public List<Motorcycle> GetAll()
        {
            return _motorcyleDal.GetAll( );
        }

        public List<MotorcyleDetailDto> GetMotorcyleDetails()
        {
            return _motorcyleDal.GetMotorcyleDetails();
        }
    }
}
