using lab4mongo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4mongo.services
{
  public interface IEntityServices<T>
    where T : IMongoEntity
  {
    void Create(T entity);
    void Delete(string id);
    T GetById(string id);
    void Update(T entity);
    List<T> GetAll();
  }
}
