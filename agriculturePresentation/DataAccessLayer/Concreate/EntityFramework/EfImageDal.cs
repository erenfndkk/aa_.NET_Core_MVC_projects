﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repositort;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class EfImageDal : GenericRepository<Image>, IImageDal
    {
    }
}
