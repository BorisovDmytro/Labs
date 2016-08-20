using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Lab6
{
  

  public class ManagerDb
  {
    public ServiceFactoryImpl Factory;
    protected MongoClient client;
    protected IMongoDatabase db;
    public ManagerDb()
    {

    }

    public void Connect(string url, string name)
    {
      client = new MongoClient(url);
      db = client.GetDatabase(name);
      Factory = new ServiceFactoryImpl(db);
    }
  }
}
