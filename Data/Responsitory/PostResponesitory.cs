﻿using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IPostResponesitory
    {

    }
 public   class PostResponesitory:ResponsitoryBase<Post>,IPostResponesitory
    {
        public PostResponesitory(DbFactory dbFactory):base(dbFactory) { }
    }
}
