using lab4mongo.DataBasesManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5.Handlers
{
  public abstract class HandlerBase : IHttpHandler
  {
    public ManagerDb DataManager
    {
      get
      {
        return ((Global)HttpContext.Current.ApplicationInstance).DataManager;
      }
    }

    public bool IsReusable
    {
      get
      {
        return true;
      }
    }

    public void ProcessRequest(HttpContext context)
    {
      if(context.Request.HttpMethod.Equals("GET")) {
        GET(context);
      } else if(context.Request.HttpMethod.Equals("POST")) {
        POST(context);
      } else if(context.Request.HttpMethod.Equals("PUT")) {
        PUT(context);
      } else if(context.Request.HttpMethod.Equals("DELETE")) {
        DELETE(context);
      } else {
        UndefMethod(context);
      }
    }

    public virtual void UndefMethod(HttpContext context)
    {
      Console.Write("UNDEFINE METHOD");
    }

    public abstract void GET(HttpContext context);
    public abstract void POST(HttpContext context);
    public abstract void PUT(HttpContext context);
    public abstract void DELETE(HttpContext context);
  }
}