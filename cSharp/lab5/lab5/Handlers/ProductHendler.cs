using lab4mongo.Entities;
using lab4mongo.services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5.Handlers
{
  public class ProductHendler : HandlerBase
  {
    public override void DELETE(HttpContext context)
    {
      string id = context.Request.QueryString["Id"];
      IProductService service = DataManager.Factory.CreateProductService();
      service.Delete(id);
      context.Response.Write("success");
    }

    public override void GET(HttpContext context)
    {
      string id = context.Request.QueryString["seller"];
      IProductService service = DataManager.Factory.CreateProductService();
      List<Product> products = service.GetAllSellerProducts(id);
      var json = JsonConvert.SerializeObject(products);
      context.Response.Write(json.ToString());
    }

    public override void POST(HttpContext context)
    {
      string id = context.Request.QueryString["Id"];
      string name = context.Request.QueryString["Name"];
      string manufacturer = context.Request.QueryString["Manufacturer"];
      string price = context.Request.QueryString["Price"];

      IProductService service = DataManager.Factory.CreateProductService();
      Product product = service.GetById(id);
      context.Response.Write("success");
    }

    public override void PUT(HttpContext context)
    {
      string name = context.Request.QueryString["Name"];
      string manufacturer = context.Request.QueryString["Manufacturer"];
      string price = context.Request.QueryString["Price"];
      string id = context.Request.QueryString["Seller"];

      IProductService service = DataManager.Factory.CreateProductService();
      Product product = new Product(name, manufacturer, double.Parse(price), id);
      service.Create(product);
      context.Response.Write("success");
    }
  }
}