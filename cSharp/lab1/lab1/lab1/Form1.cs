using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
  public partial class Form1 : Form
  {
    private StudentDataBase dataBase;

    public Form1()
    {
      dataBase = new StudentDataBase();
      InitializeComponent();
      UpdateTableView();
    }

    private void UpdateTableView()
    {
      dataGridView1.Rows.Clear();
      dataGridView1.ColumnCount = 5;
      dataGridView1.Columns[0].Name = "Code";
      dataGridView1.Columns[1].Name = "Name";
      dataGridView1.Columns[2].Name = "Second name";
      dataGridView1.Columns[3].Name = "Age";
      dataGridView1.Columns[4].Name = "Group name";
      Student[] students = dataBase.GetAll();
      foreach(Student var in students) {
        dataGridView1.Rows.Add(var.GetGuiData());
      }
    }

    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
      StudentDialog dlg = new StudentDialog();
      dlg.ShowDialog(this);
      Student student = dlg.GetStudent();
      if (student != null)
      {
        dataBase.Add(student);
        UpdateTableView();
      }
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      dataBase.Remove();
      UpdateTableView();
    }
  }
}
