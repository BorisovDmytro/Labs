using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab4mongo.Entities;

namespace lab4mongo.services
{
  public interface IServiceFactory
  {
    IProductService CreateProductService();
    ISellerService CreateSellerService();
  }
}
