﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
  public abstract class ISellerService : EntityService<Seller>
  {
    public ISellerService(MongoCollectionHandler<Seller> handler)
      : base(handler) {}
  }
}
