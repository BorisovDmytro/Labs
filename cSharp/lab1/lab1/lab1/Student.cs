using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
  public class Student
  {
    private int code;
    private string name;
    private string secondName;
    private int age;
    private string groupName;

    public Student() { 

}

    public Student(int code, string name, string secondName, int age, string groupName)
    {
      this.code = code;
      this.name = name;
      this.age = age;
      this.secondName = secondName;
      this.groupName = groupName;
    }

    public virtual Object[] GetGuiData()
    {
      return new Object[]{code, name, secondName, age, groupName};
    }

    public void SetCode(int value)
    {
      code = value;
    }

    public int Code()
    {
      return code;
    }

    public void SetName(string value)
    {
      this.name = value;
    }

    public string Name()
    {
      return name;
    }

    public void SetSecondName(string value)
    {
      secondName = value;
    }

    public string SecondName()
    {
      return secondName;
    }

    public void SetAge(int value)
    {
      age = value;
    }

    public int Age()
    {
      return age;
    }

    public void SetGroupName(string value)
    {
      groupName = value;
    }

    public string GroupName()
    {
      return groupName;
    }

    public override bool Equals(Object obj)
    {
      return ((Student)obj).code == code; 
    }

    public override int GetHashCode()
    {
      return code;
    }
  }
}
