﻿using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IMenuResponsesitory
    {

    }
   public class MenuResponsesitory: ResponsitoryBase<Menu>,IMenuResponsesitory
    {
        public MenuResponsesitory(DbFactory dbFactory): base(dbFactory)
        {
                
        }
    }
}
