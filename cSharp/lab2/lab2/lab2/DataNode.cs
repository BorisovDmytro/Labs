using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
  public class DataNode : TreeNode
  {
    private List<string> parameters = null;
    private string returnValue;
    private string type;

    public void setType(string str)
    {
      type = str;
    }

    public void addParameter(string str)
    {
      if(parameters == null)
      {
        parameters = new List<string>();
      }
      parameters.Add(str);
    }

    public void setReturnValue(string str)
    {
      returnValue = str;
    }

    public List<string> getParameters()
    {
      return parameters;
    }

    public string getRetrunValue()
    {
      return returnValue;
    }

    public string getType()
    {
      return type;
    }
  }
}
