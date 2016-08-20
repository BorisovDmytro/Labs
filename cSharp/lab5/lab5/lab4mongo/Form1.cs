using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using lab4mongo.Entities;
using lab4mongo.DataBasesManager;
using lab4mongo.services;
using lab4mongo.gui;

namespace lab4mongo
{
  public partial class Form1 : Form
  {
    private ManagerDb dbManager;

    private string currentSellerId;
    public Form1()
    {
      InitializeComponent();
      dbManager = new ManagerDb();
    }

    private void OnConnect(object sender, EventArgs e)
    {
      ConnectDlg dlg = new ConnectDlg();
      if(DialogResult.OK == dlg.ShowDialog())
      {
        dbManager.Connect(dlg.Url, dlg.DataBase);
        fillSeller();
      }
    }

    public void fillSeller()
    {
      viewSeller.Rows.Clear();
      viewSeller.Columns.Clear();
      viewSeller.Columns.Add("id","ID");
      viewSeller.Columns.Add("name", "Name");
      viewSeller.Columns.Add("secondName", "SecondName");
      viewSeller.Columns.Add("age", "Age");

      ISellerService sellerService = dbManager.Factory.CreateSellerService();
      List<Seller> sellers = sellerService.GetAll();
      foreach(Seller sllr in sellers)
      {
        DataGridViewRow row = new DataGridViewRow();
        DataGridViewTextBoxCell cell0 = new DataGridViewTextBoxCell();
        DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
        DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
        DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();

        cell0.Value = sllr.Id.ToString();
        cell0.ValueType = typeof(string);

        cell1.Value = sllr.Name;
        cell1.ValueType = typeof(string);

        cell2.Value = sllr.SecondName;
        cell2.ValueType = typeof(string);

        cell3.Value = sllr.Age;
        cell3.ValueType = typeof(int);

        row.Cells.Add(cell0);
        row.Cells.Add(cell1);
        row.Cells.Add(cell2);
        row.Cells.Add(cell3);
        viewSeller.Rows.Add(row);
      }
    }

    public void fillProduct(string idSeller)
    {
      currentSellerId = idSeller;
      viewProduct.Rows.Clear();
      viewProduct.Columns.Clear();
      viewProduct.Columns.Add("id", "ID");
      viewProduct.Columns.Add("name", "Name");
      viewProduct.Columns.Add("manufacturer", "Manufacturer");
      viewProduct.Columns.Add("price", "Price");

      IProductService productService = dbManager.Factory.CreateProductService();
      List<Product> products = productService.GetAllSellerProducts(idSeller);
      foreach(Product product in products)
      {
        DataGridViewRow row = new DataGridViewRow();
        DataGridViewTextBoxCell cell0 = new DataGridViewTextBoxCell();
        DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
        DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
        DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();

        cell0.Value = product.Id.ToString();
        cell0.ValueType = typeof(string);

        cell1.Value = product.Name;
        cell1.ValueType = typeof(string);

        cell2.Value = product.Manufacturer;
        cell2.ValueType = typeof(string);

        cell3.Value = product.Price;
        cell3.ValueType = typeof(double);

        row.Cells.Add(cell0);
        row.Cells.Add(cell1);
        row.Cells.Add(cell2);
        row.Cells.Add(cell3);
        viewProduct.Rows.Add(row);
      }
    }

    private void addToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      SellerDlg dlg = new SellerDlg();
      if(DialogResult.OK == dlg.ShowDialog())
      {
        Seller seller = dlg.GetResualt();
        ISellerService service = dbManager.Factory.CreateSellerService();
        service.Create(seller);
        fillSeller();
      }
    }

    private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (viewSeller.SelectedRows.Count == 0)
      {
        MessageBox.Show("First selected", "Error");
        return;
      }
      string id = viewSeller.SelectedRows[0].Cells[0].Value.ToString();
      ISellerService service = dbManager.Factory.CreateSellerService();
      Seller seller = service.GetById(id);
      SellerDlg dlg = new SellerDlg(seller);
      if(DialogResult.OK == dlg.ShowDialog())
      {
        seller = dlg.GetResualt();
        service.Update(seller);
        fillSeller();
      }
    }

    private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (viewSeller.SelectedRows.Count == 0)
      {
        MessageBox.Show("First selected", "Error");
        return;
      }
      string id = viewSeller.SelectedRows[0].Cells[0].Value.ToString();
      ISellerService service = dbManager.Factory.CreateSellerService();
      service.Delete(id);
      fillSeller();
    }

    private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (viewSeller.SelectedRows.Count == 0)
      {
        MessageBox.Show("First selected", "Error");
        return;
      }
      IProductService service = dbManager.Factory.CreateProductService();
      string idSeller = viewSeller.SelectedRows[0].Cells[0].Value.ToString();
      ProductDlg dlg = new ProductDlg();
      if(DialogResult.OK == dlg.ShowDialog())
      {
        Product product = dlg.GetResualt();
        product.SellerId = new ObjectId(idSeller);
        service.Create(product);
        fillProduct(idSeller);
      }
      
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (viewProduct.SelectedRows.Count == 0)
      {
        MessageBox.Show("First selected", "Error");
        return;
      }
      IProductService service = dbManager.Factory.CreateProductService();
      string id = viewProduct.SelectedRows[0].Cells[0].Value.ToString();
      service.Delete(id);
      fillProduct(currentSellerId);
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (viewProduct.SelectedRows.Count == 0)
      {
        MessageBox.Show("First selected", "Error");
        return;
      }
      IProductService service = dbManager.Factory.CreateProductService();
      string id = viewProduct.SelectedRows[0].Cells[0].Value.ToString();
      Product product = service.GetById(id);
      ProductDlg dlg = new ProductDlg(product);
      if(DialogResult.OK == dlg.ShowDialog())
      {
        product = dlg.GetResualt();
        service.Update(product);
        fillProduct(currentSellerId);
      }
    }

    private void OnViewSellerClick(object sender, EventArgs e)
    {
      if (viewSeller.SelectedRows.Count == 0)
        return;
      string id = viewSeller.SelectedRows[0].Cells[0].Value.ToString();
      fillProduct(id);
    }
  }
}
