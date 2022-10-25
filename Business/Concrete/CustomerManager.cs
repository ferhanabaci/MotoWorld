using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        // ben customerManeger olarak veri erişim katmanına bagımlıyım ama biraz zayıf bagımlılıgım var çünkü ben interface üzerinden referans üzerinden bagımlıyım oyüzden dataAccess katmanında istedigin kadar at koşturabilirsin Yeter ki kurallarıma uy
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
                
        }
        public List<Customer> GetAll()
        {//iş kodlar
            return _customerDal.GetAll();
        }

        // c diye belirttiğimiz veri tabanından soruyor aslında 
        //Select * from Categories where CategoryId = 3 gibi çalışıyor 
        public Customer GetById(int customerId)
        {
            return _customerDal.Get(c =>c.CustomerId == customerId);
        }
    }
}
