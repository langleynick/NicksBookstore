using NicksBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NicksBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
