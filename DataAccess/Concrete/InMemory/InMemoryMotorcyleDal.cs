using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryMotorcyleDal : IMotorcyleDal
    {
        List<Motorcycle> _motorcycles;
        public InMemoryMotorcyleDal()
        {
            _motorcycles = new List<Motorcycle> {
                new Motorcycle{BrandId=1,MotorcyleName="Yamaha",ModelYear=1,ColorId=1,DailyPrice=205000,Description="Sıfır",MotorcycleId=1}
            };
        }
        public void Add(Motorcycle motorcycle)
        {
            _motorcycles.Add(motorcycle);
        }

        public void Delete(Motorcycle motorcycle)
        {
            Motorcycle motorcycleDelete= _motorcycles.SingleOrDefault(m => m.MotorcycleId == motorcycle.MotorcycleId);
            _motorcycles.Remove(motorcycleDelete);
        }

        public Motorcycle Get(Expression<Func<Motorcycle, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Motorcycle> GetAll()
        {
            return _motorcycles;
        }

        public List<Motorcycle> GetAll(Expression<Func<Motorcycle, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Motorcycle> GetAllBrandId(int brandId)
        {
            return _motorcycles.Where(m => m.BrandId == brandId).ToList();
        }

        public List<Motorcycle> GetAllColorId(int colorId)
        {
            return _motorcycles.Where(m => m.ColorId == colorId).ToList();
        }

        public List<MotorcyleDetailDto> GetMotorcyleDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Motorcycle motorcycle)
        {
            // Gönderdiğim ürün Idsine sahip olan listedeki ürünü bul 
            Motorcycle motorcyleUpdate = _motorcycles.SingleOrDefault(m => m.MotorcycleId == motorcycle.MotorcycleId);
            motorcyleUpdate.MotorcyleName = motorcycle.MotorcyleName;
            motorcyleUpdate.DailyPrice = motorcycle.DailyPrice;
            motorcyleUpdate.Description = motorcycle.Description;
            motorcyleUpdate.MotorcycleId = motorcycle.MotorcycleId; 
            motorcyleUpdate.ModelYear = motorcycle.ModelYear;
            motorcyleUpdate.BrandId = motorcycle.BrandId;
            motorcyleUpdate.ColorId = motorcycle.ColorId;
        }
    }
}
