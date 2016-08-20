using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
  public partial class ProductDialog : Form
  {
    public string Name { get; set; }
    public string Price { get; set; }

    public ProductDialog()
    {
      InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      Name = boxName.Text;
      Price = boxPrice.Text;
      if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Price))
      {
        MessageBox.Show("Invalid input data");
        return;
      }
      DialogResult = DialogResult.OK;
      Close();
    }

    private void btnCansel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }
  }
}
