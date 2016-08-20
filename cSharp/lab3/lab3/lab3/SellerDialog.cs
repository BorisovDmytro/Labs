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
  public partial class SellerDialog : Form
  {
    public string Name { get; set; }
    public string SecondName { get; set; }

    public SellerDialog()
    {
      InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      Name = boxName.Text;
      SecondName = boxSecond.Text;
      if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(SecondName))
      {
        MessageBox.Show("Empty folder!");
      } else {
        DialogResult = DialogResult.OK;
        Close();
      }
    }

    private void btnCansel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    public void setData(string name, string secondName)
    {
      boxName.Text = name;
      boxSecond.Text = secondName;
    }
  }
}
