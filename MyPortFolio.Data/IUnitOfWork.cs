﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortFolio.Data
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
