using lab4mongo.DataBasesManager;
using lab4mongo.Entities;
using lab4mongo.services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5.Handlers
{
  public class SellerHandler : HandlerBase
  { 

    public override void DELETE(HttpContext context)
    {
      string id = context.Request.QueryString["id"];
      ISellerService service = DataManager.Factory.CreateSellerService();
      service.Delete(id);
      context.Response.Write("success");
    }

    public override void GET(HttpContext context)
    {
      ISellerService service = DataManager.Factory.CreateSellerService();
      List<Seller> sellers = service.GetAll();
      var json = JsonConvert.SerializeObject(sellers);
      context.Response.Write(json.ToString());
    }

    public override void POST(HttpContext context)
    {
      string id = context.Request.QueryString["Id"];
      string name = context.Request.QueryString["Name"];
      string secondName = context.Request.QueryString["SecondName"];
      string age = context.Request.QueryString["Age"];

      ISellerService service = DataManager.Factory.CreateSellerService();
      Seller seller = service.GetById(id);
      seller.Name = name;
      seller.SecondName = secondName;
      seller.Age = int.Parse(age);
      service.Update(seller);
      context.Response.Write("success");
    }

    public override void PUT(HttpContext context)
    {
      string name = context.Request.QueryString["Name"];
      string secondName = context.Request.QueryString["SecondName"];
      string age = context.Request.QueryString["Age"];
      ISellerService service = DataManager.Factory.CreateSellerService();
      Seller seller = new Seller(name, secondName, int.Parse(age));
      service.Create(seller);
      context.Response.Write("success");
    }
  }
}