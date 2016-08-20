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

namespace lab4mongo.gui
{
  public partial class ProductDlg : Form
  {
    private Product mProduct = null;
    public ProductDlg()
    {
      InitializeComponent();
      DialogResult = DialogResult.Cancel;
    }

    public ProductDlg(Product product)
    {
      InitializeComponent();
      mProduct = product;
      textBox1.Text = product.Name;
      textBox2.Text = product.Manufacturer;
      textBox3.Text = product.Price.ToString();
    }

    public Product GetResualt()
    {
      return mProduct;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (mProduct == null)
        mProduct = new Product();
      mProduct.Name = textBox1.Text;
      mProduct.Manufacturer = textBox2.Text;
      mProduct.Price = int.Parse(textBox3.Text);
      DialogResult = DialogResult.OK;
      Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
