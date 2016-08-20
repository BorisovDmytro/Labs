using lab4mongo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4mongo.gui
{
  public partial class SellerDlg : Form
  {
    public Seller obj = null;
    public SellerDlg()
    {
      InitializeComponent();
      DialogResult = DialogResult.Cancel;
    }

    public SellerDlg(Seller seller)
    {
      InitializeComponent();
      DialogResult = DialogResult.Cancel;
      obj = seller;
      textBox1.Text = obj.Name;
      textBox2.Text = obj.SecondName;
      textBox3.Text = obj.Age.ToString();
    }

    public Seller GetResualt()
    {
      return obj;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (obj == null)
        obj = new Seller();
      obj.Name = textBox1.Text;
      obj.SecondName = textBox2.Text;
      obj.Age = int.Parse(textBox3.Text);
      DialogResult = DialogResult.OK;
      Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
