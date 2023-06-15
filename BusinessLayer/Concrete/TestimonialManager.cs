using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonials entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonials entity)
        {
            throw new NotImplementedException();
        }

        public Testimonials TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonials> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate(Testimonials entity)
        {
            throw new NotImplementedException();
        }
    }
}
