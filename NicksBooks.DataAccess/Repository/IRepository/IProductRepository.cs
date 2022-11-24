using NicksBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NicksBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        public void Update(Product product);
    }
}
