using lab4mongo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4mongo.DataBasesManager;

namespace lab4mongo.services
{
  public abstract class ISellerService : EntityService<Seller>
  {
    public ISellerService(MongoCollectionHandler<Seller> handler)
      : base(handler) {}
  }
}
