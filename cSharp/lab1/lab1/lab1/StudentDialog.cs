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
  public partial class StudentDialog : Form
  {
    private Student student = null;

    public StudentDialog()
    {
      InitializeComponent();
    }

    private void CanselButton_Click(object sender, EventArgs e)
    {
      student = null;
      Close();
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
      if (student == null)
        student = new Student();
      student.SetCode(int.Parse(textBoxCode.Text));
      student.SetAge(int.Parse(textBoxAge.Text));
      student.SetName(textBoxName.Text);
      student.SetSecondName(textBoxSecondName.Text);
      student.SetGroupName(textBoxGroupName.Text);
      Close();
    }

    public void SetStudent(Student student)
    {
      textBoxCode.Text = student.Code().ToString();
      textBoxName.Text = student.Name();
      textBoxGroupName.Text = student.GroupName();
      textBoxSecondName.Text = student.SecondName();
      textBoxAge.Text = student.Age().ToString();
      this.student = student;
    }

    public Student GetStudent()
    {
      return student;
    }
  }
}
