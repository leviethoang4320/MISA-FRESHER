﻿using System;
using System.Collections.Generic;
using System.Text;
using MISA.Common.Models;

namespace MISA.DataLayer.Interfaces
{
    public interface IStoreRepository: IDbContext<Store>
    {
        //ublic IEnumerable<Store> GetFilter(Object filter);
    }
}
