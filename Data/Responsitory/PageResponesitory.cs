﻿using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IPageResponesitory
    {

    }
    public class PageResponesitory : ResponsitoryBase<Page>, IPageResponesitory
    
    {
        public PageResponesitory(DbFactory dbFactory):base(dbFactory)
        {
        }
    }
}
