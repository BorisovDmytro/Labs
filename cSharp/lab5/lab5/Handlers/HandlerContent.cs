using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5.Handlers
{
  public class HandlerContent : HandlerBase
  {
    public override void DELETE(HttpContext context)
    {
      throw new NotImplementedException();
    }

    public override void GET(HttpContext context)
    {
      context.Response.WriteFile("content/html/index.html");
    }

    public override void POST(HttpContext context)
    {
      throw new NotImplementedException();
    }

    public override void PUT(HttpContext context)
    {
      throw new NotImplementedException();
    }
  }
}