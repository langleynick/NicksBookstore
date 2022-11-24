﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NicksBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        ISP_Call SP_Call { get; }

       public void Save();
    }
}
