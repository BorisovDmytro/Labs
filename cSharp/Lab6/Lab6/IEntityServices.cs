
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
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
