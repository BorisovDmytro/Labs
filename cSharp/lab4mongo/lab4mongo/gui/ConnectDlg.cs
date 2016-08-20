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
  public partial class ConnectDlg : Form
  {
    public string Url { get; set; }
    public string DataBase { get; set; }
    public ConnectDlg()
    {
      InitializeComponent();
      DialogResult = DialogResult.Cancel;
      textBox1.Text = "mongodb://localhost:27017";
      textBox2.Text = "test1";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Url = textBox1.Text;
      DataBase = textBox2.Text;
      if(!Url.Equals(string.Empty) || !DataBase.Equals(string.Empty))
      {
        Close();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }
  }
}
