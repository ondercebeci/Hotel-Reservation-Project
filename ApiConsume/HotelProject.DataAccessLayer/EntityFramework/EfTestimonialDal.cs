﻿using HotelProject.DataAccessLAyer.Abstract;
using HotelProject.DataAccessLAyer.Concrate;
using HotelProject.DataAccessLAyer.Repositories;
using HotelProject.EntityLayer.Conctate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLAyer.EntityFramework
{
  public  class EfTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonialDal(Context context):base(context)
        {
        

        }
    }
}
