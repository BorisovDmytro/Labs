using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace Lab6
{
  public class SelllerServiceImpl 
    : ISellerService
  {
    public SelllerServiceImpl(MongoCollectionHandler<Seller> handler)
      : base(handler) {}

    public override void Update(Seller entity)
    {
      var filter = Builders<Seller>.Filter.Eq(x => x.Id, entity.Id);
      var updater = Builders<Seller>.Update
                   .Set(x => x.Name, entity.Name)
                   .Set(x => x.SecondName, entity.SecondName)
                   .Set(x => x.Age, entity.Age);
      handler.Collection.UpdateOne(filter, updater);
    }
  }
}
