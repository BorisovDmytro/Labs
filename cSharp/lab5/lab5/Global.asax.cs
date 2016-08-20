using lab4mongo.DataBasesManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace lab5
{
  public class Global : System.Web.HttpApplication
  {

    public ManagerDb DataManager { get; private set; }

    protected void Application_Start(object sender, EventArgs e)
    {

    }

    public override void Init()
    {
      base.Init();
      DataManager = new ManagerDb();
      DataManager.Connect("mongodb://localhost:27017", "test1");
    }
  }
}