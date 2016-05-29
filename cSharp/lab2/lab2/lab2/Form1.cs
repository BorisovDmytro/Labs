using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
  public partial class Form1 : Form
  {
    protected Assembly assembly;

    public Form1()
    {
      InitializeComponent();
    
      ImageList images = new ImageList();
      images.Images.Add(Image.FromFile("./res/class.png"));
      images.Images.Add(Image.FromFile("res/intarface.png"));
      images.Images.Add(Image.FromFile("res/folder.png"));
      images.Images.Add(Image.FromFile("res/methods.png"));
      images.Images.Add(Image.FromFile("res/constructor.png"));
      images.Images.Add(Image.FromFile("res/library.png"));

      dataGridView1.ColumnCount = 2;
      dataGridView1.Columns[0].HeaderText = "Name";
      dataGridView1.Columns[1].HeaderText = "Value";

      treeView1.ImageList = images;
      this.treeView1.Click += new System.EventHandler(this.onTreeViewClick);
    }

    protected void onTreeViewClick(object sender, EventArgs e)
    {
      DataNode selectedNode = treeView1.SelectedNode as DataNode;
      if (selectedNode == null) return;
      dataGridView1.Rows.Clear();

      dataGridView1.Rows.Add(new object[] {"Type node: ", selectedNode.getType() });
      if(selectedNode.getParameters() != null)
      {
        foreach(string value in selectedNode.getParameters())
        {
          dataGridView1.Rows.Add(new object[] { "argument: ", value });
        }

        dataGridView1.Rows.Add(new object[] { "return type: ", selectedNode.getRetrunValue() });
      }
      
    }

    protected string getOpenModuleUrl()
    {
      OpenFileDialog fileDlg = new OpenFileDialog();
      fileDlg.Title = "Open assembly file";
      fileDlg.Filter = "Dll files (*.dll)|*.dll|Exe files (*.exe) | *.exe | All files(*.*) | *.* ";
      return (fileDlg.ShowDialog() == DialogResult.OK) ? fileDlg.FileName : null;
    }

    protected Assembly openAssembly(string strPath)
    {
      Assembly assembly;
      try
      {
        assembly = Assembly.LoadFrom(strPath);
      }
      catch (Exception exp)
      {
        assembly = null;
        MessageBox.Show("Error load assembly file: " + exp.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      return assembly;
    }

    protected void addRoot(TreeNode root, Type[] types)
    {
      DataNode node = null;
      foreach(Type var in types)
      {
        node = new DataNode();
        node.Text = var.ToString();
        node.setType("Module");
        if (var.IsClass)
        {
          node.ImageIndex = 0;
          node.SelectedImageIndex = 0;
          traseSubLevel(node, var);
          root.Nodes.Add(node);
        }
        else if(var.IsInterface)
        {
          node.ImageIndex = 1;
          node.SelectedImageIndex = 1;
          traseSubLevel(node, var);
          root.Nodes.Add(node);
        }
      }
    }

    protected void parseFields(TreeNode parent, Type type)
    {
      DataNode node = null;
      FieldInfo[] fields = type.GetFields();
      foreach (FieldInfo var in fields)
      {
        node = new DataNode();
        node.Text = var.FieldType.Name + " " + var.Name;
        node.setType("Field");
        node.setReturnValue(var.FieldType.Name);
        node.ImageIndex = 2;
        node.SelectedImageIndex = 2;
        parent.Nodes.Add(node);
      }
    }

    protected void parseConstructor(TreeNode parent, Type type)
    {
      DataNode node = null;
      ConstructorInfo[] constructors = type.GetConstructors();

      foreach (ConstructorInfo constructor in constructors)
      {
        string strParametrs = "";
        node = new DataNode();
        ParameterInfo[] parametrs = constructor.GetParameters();
        foreach (ParameterInfo parametr in parametrs)
        {
          node.addParameter(parametr.ParameterType.Name);
          strParametrs += parametr.ParameterType.Name + ", ";
        }
        strParametrs = strParametrs.TrimEnd(',');
        node.Text = constructor.Name + "( " + strParametrs + " )";
        node.setType("Constructors");
        node.setReturnValue(constructor.Name);
        node.ImageIndex = 4;
        node.SelectedImageIndex = 4;
        parent.Nodes.Add(node);
      }
    }

    protected void parseMethod(TreeNode parent, Type type)
    {
      DataNode node = null;
      MethodInfo[] methods = type.GetMethods();
      foreach (MethodInfo method in methods)
      {
        node = new DataNode();
        string strParametrs = "";
        ParameterInfo[] parametrs = method.GetParameters();
        foreach (ParameterInfo parametr in parametrs)
        {
          node.addParameter(parametr.ParameterType.Name);
          strParametrs += parametr.ParameterType.Name + ", ";
        }
        strParametrs = strParametrs.TrimEnd(',');
        node.Text = (method.IsPublic ? "public " : "private ") + method.ReflectedType.Name + " " +
                    method.Name + "( " + strParametrs + " )";
        node.ImageIndex = 3;
        node.SelectedImageIndex = 3;
        node.setType("Method");
        node.setReturnValue(method.Name);
        parent.Nodes.Add(node);
      }
    }

    protected void traseSubLevel(TreeNode parent, Type type)
    {
      parseFields(parent, type);
      parseConstructor(parent, type);
      parseMethod(parent, type);
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      treeView1.Nodes.Clear();
      string path = getOpenModuleUrl();
      if (path == null) return;
      assembly = openAssembly(path);
      if (assembly == null) return;

      TreeNode root = new TreeNode();
      root.Text = assembly.GetName().Name;
      root.ImageIndex = 5;
      root.SelectedImageIndex = 5;
      treeView1.Nodes.Add(root);
      Type[] types = assembly.GetTypes();
      addRoot(root, types);
    }
  }
}
