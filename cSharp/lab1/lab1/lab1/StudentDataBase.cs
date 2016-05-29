using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
  public class StudentDataBase
  {
    private Queue<Student> dataStudent;
 
    public StudentDataBase()
    {
      dataStudent = new Queue<Student>();
      
    }

    public Student[] GetAll()
    {
      return dataStudent.ToArray();
    }

    public bool Add(Student obj)
    {
      if (obj == null) 
        return false;
      dataStudent.Enqueue(obj);
      return true;
    }

    public void Remove()
    {
      dataStudent.Dequeue();
    }


  }
}
