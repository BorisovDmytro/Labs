using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
  public class ConnectSetting
  {
    public ConnectSetting() { }
    public ConnectSetting(string host, int port, string dataBaseName, string user, string password)
    {
      mHost = host;
      mPort = port;
      mDataBaseName = dataBaseName;
      mUser = user;
      mPassword = password;
    }

    public string mHost { get; set; }
    public int mPort { get; set; }
    public string mDataBaseName { get; set; }
    public string mUser { get; set; }
    public string mPassword { get; set; }
  }
}
