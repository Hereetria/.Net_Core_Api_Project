﻿using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialdal;

        public TestimonialManager(ITestimonialDal testimonialdal)
        {
            _testimonialdal = testimonialdal;
        }

        public void TDelete(Testimonial t)
        {
            _testimonialdal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialdal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialdal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonialdal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialdal.Update(t);
        }
    }
}